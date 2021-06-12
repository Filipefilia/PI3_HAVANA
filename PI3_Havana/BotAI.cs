using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace PI3_Havana
{
    class BotAI
    {
        public string[] currentPlayer { get; private set; }

        public string rollDice;

        public int[] dice = new int[4];

        public bool playing = false;

        public int gameId;

        public bool close = false;

        bool STOP = false;

				string move = "";

        bool PlayerTurn;
        //[climber][x,y]
        int[,] ClimbersPos = new int[3, 2];

        public int[,,] PlayerBases = new int[11, 13, 1];

        public int[,,] EnemyBases = new int[11, 13, 1];

        int[] ValidTrail = new int[11];

        bool[] Climbers = new bool[3] { false, false, false };

        int ClimbersInUse = 0;

        public BotAI()
        {
            resetVariables();
        }
        
        public void resetVariables()
        {
            for (int i = 0; i < 11; i++)
            {
                ValidTrail[i] = 1;
            }
        }

        public int[] CanConquer(int[] max_size, bool d_dice)
        {
            int trailLeft = 2; //linhas comecam no zero e se falta 1, somar +1.
            int[] canConq = new int[12];

            if (d_dice)
            {
                //para trilhas onde faltam 2 casas para o topo.
                trailLeft++;
            }
            //zera a array
            for (int i = 0; i < 12; i++)
            {
                canConq[i] = 0;
            }
            //procura por trilhas que faltam apenas 1 ou 2 posicao para dominar.
            for (int i = 0; i < 11; i++)
            {
                if (PlayerBases[i, max_size[i] - trailLeft, 0] == 1 && ValidTrail[i] != 0)
                {
                    canConq[i] = 1;
                    canConq[11]++;
                }
            }
            //retorna array com todas as colunas que podem ser dominadas naquele turno.
            return canConq;
        }

        public void ChooseMove()
        {
            //[perm][comb, comb(hex), ordem]
            string[,] perm = new string[3, 3];
            int choice = -1;

            if (rollDice != "" && rollDice[0].ToString() != "E")
            {
                string[] rolled_dices = rollDice.Replace("\r", "").Split('\n');
                for (int i = 0; i < 4; i++)
                {
                    dice[i] = Int32.Parse(rolled_dices[i][1].ToString());
                }

                int[] soma = new int[6];
                soma[0] = dice[0] + dice[1];
                soma[1] = dice[0] + dice[2];
                soma[2] = dice[0] + dice[3];
                soma[3] = dice[1] + dice[2];
                soma[4] = dice[1] + dice[3];
                soma[5] = dice[3] + dice[2];

                perm[0, 0] = soma[0].ToString() + soma[5].ToString();
                perm[0, 1] = soma[0].ToString("X") + soma[5].ToString("X");
                perm[0, 2] = "1234";

                perm[1, 0] = soma[1].ToString() + soma[4].ToString();
                perm[1, 1] = soma[1].ToString("X") + soma[4].ToString("X");
                perm[1, 2] = "1324";

                perm[2, 0] = soma[2].ToString() + soma[3].ToString();
                perm[2, 1] = soma[2].ToString("X") + soma[3].ToString("X");
                perm[2, 2] = "1423";

                int[] max_size = new int[] { 3, 5, 7, 9, 11, 13, 11, 9, 7, 5, 3 };
                //procura por trilhas que foram dominadas para excluir.
                for (int i = 0; i < 11; i++)
                {
                    if (EnemyBases[i, max_size[i] - 1, 0] != 0 || PlayerBases[i, max_size[i] - 1, 0] != 0)
                    {
                        ValidTrail[i] = 0;
                    }
                }
                bool moveOne = false, ready = false;

                while (!ready)
                {
                    if (!moveOne)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int t1, t2;
                            t1 = Convert.ToInt32(perm[i, 1].Substring(0, 1), 16) - 2;
                            t2 = Convert.ToInt32(perm[i, 1].Substring(1, 1), 16) - 2;
                            //se as 2 trilhas podem ser colocadas
                            if (ValidTrail[t1] != 0 && ValidTrail[t2] != 0)
                            {
                                choice = i;
                                break;
                            }
                        }
                        //se ha possibilidade de jogar nas 2 trilhas
                        if (choice != -1)
                        {
                            //HOTFIX
                            int t1, t2;
                            t1 = Convert.ToInt32(perm[choice, 1].Substring(0, 1), 16) - 2;
                            t2 = Convert.ToInt32(perm[choice, 1].Substring(1, 1), 16) - 2;
                            //se saiu dados duplos
                            if (t1 == t2)
                            {
                                //se falta apensa uma casa para dominar
                                if (PlayerBases[t1, max_size[t1] -2, 0] == 1) 
                                {
                                    perm[choice, 1] = perm[choice, 1].Substring(0, 1) + "0";
                                }
                            }
                            move = Jogo.Mover(Int32.Parse(currentPlayer[0]), currentPlayer[2], perm[choice, 2], perm[choice, 1]);
                            if (move != "" && move != null)
                            {
                                if (move[0].ToString() == "E")
                                {
                                    MessageBox.Show($"{move}");
                                }
                            }
                            ready = true;
                        }
                        else
                        {
                            moveOne = true;
                        }
                    }
                    //move apenas 1 alpinista.
                    else
                    {
                        int pos = -1; 

                        for (int i = 0; i < 3; i++)
                        {
                            int t1;
                            t1 = Convert.ToInt32(perm[i, 1].Substring(0, 1), 16) - 2;
                            if (ValidTrail[t1] != 0)
                            {
                                pos = i;
                                break;
                            }
                        }
                        //se em alguma das perms o primeiro digito eh uma posicao valida.
                        if (pos != -1)
                        {

                            perm[pos, 1] = perm[pos, 1].Substring(0, 1) + "0"; 
                        }
                        else
                        {
                            //se nao, procurar por uma posicao no segundo digito.
                            for (int i = 0; i < 3; i++)
                            {
                                int t2;
                                t2 = Convert.ToInt32(perm[i, 1].Substring(1, 1), 16) - 2;
                                if (ValidTrail[t2] != 0)
                                {
                                    pos = i;
                                    break;
                                }
                            }
                            //se a segunda posicao for valida, trocar a ordem das trilhas e dos dados
                            //para o primeiro digito nao ser o zero.
                            perm[pos, 1] = perm[pos, 1].Substring(1, 1) + "0";
                            string aux;
                            aux = perm[pos, 2].Substring(0, 2);
                            perm[pos, 2] = perm[pos, 2].Substring(2, 2) + aux;
                        }
                        string move = Jogo.Mover(Int32.Parse(currentPlayer[0]), currentPlayer[2], perm[pos, 2], perm[pos, 1]);
                        if (move != "" && move != null)
                        {
                            if (move[0].ToString() == "E")
                            {
                                MessageBox.Show($"{move}");
                            }
                        }
                        ready = true;
                    }
                    
                }
                STOP = true;
            }
        }

        public int ChoosePermDouble(string[,] per, int[] mTrail, int size)
        {
            //tenta encontrar a combinacao que possui as duas trilhas a dominar.
            int perNum = -1;
            bool t1 = false, t2 = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //#TO DO: fazer verificacoes com base na ordem de prioridade das trilhas
                    //para escolher em qual jogar. (colocar dentro dos ifs)
                    if (Convert.ToInt32(per[i, 1].Substring(0, 1), 16) == mTrail[j] && !t1)
                    {
                        t1 = true;
                    }
                    if (Convert.ToInt32(per[i, 1].Substring(1, 1), 16) == mTrail[j] && !t2)
                    {
                        t2 = true;
                    }
                    //se encontrou 2 trilhas que podem ser conquistadas e jogadas.
                    if (t1 && t2)
                    {
                        perNum = i;
                        move = "both";
                        break;
                    }
                }
                if (perNum != -1)
                {
                    break;
                }
                else
                {
                    t1 = false;
                    t2 = false;
                }
            }
            return perNum;
        }

        public int ChoosePermOne(string[,] per, int[] mTrail, int size)
        {
            //#TO DO: verificar todas as bases possiveis e decidir a melhor.
            int perNum = -1;
            bool found = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Convert.ToInt32(per[i, 1].Substring(0, 1), 16) == mTrail[j] || Convert.ToInt32(per[i, 1].Substring(1, 1), 16) == mTrail[j])
                    {
                        perNum = i;
                        found = true;
                        if (Convert.ToInt32(per[i, 1].Substring(0, 1), 16) == mTrail[j])
                        {
                            move = "left";
                        }
                        else
                        {
                            move = "right";
                        }
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            return perNum;
        }

        public int[] TrailOptions(int[] conq)
        {
            //ate 11 posicoes q podem ser conquistadas + tamanho usado da array.
            int[] moveTrail = new int[12];
            int j = 0;
            for (int i = 0; i < 11; i++)
            {
                if (conq[i] != 0)
                {
                    moveTrail[j] = i + 2;
                    j++;
                }
            }
            moveTrail[11] = j;
            return moveTrail;
        }

        public void Move()
        {
            string dice_order, dice_value;
            //int l_value, r_value;
            bool d_dice = false;
            bool move_ready = false;
            int comb = -1;

            //11 colunas + numero de colunas dominaveis(conquer[11])
            int[] conquer = new int[12];

            //para nao dar problema com o indice 0
            int[] doubles = new int[3] { -1, -1, -1 };

            //[perm][comb, comb(hex), ordem]
            string[,] perm = new string[3, 3];

            if (rollDice != "" && rollDice[0].ToString() != "E")
            {
                string[] rolled_dices = rollDice.Replace("\r", "").Split('\n');
                for (int i = 0; i < 4; i++)
                {
                    dice[i] = Int32.Parse(rolled_dices[i][1].ToString());
                }

                int[] soma = new int[6];
                soma[0] = dice[0] + dice[1];
                soma[1] = dice[0] + dice[2];
                soma[2] = dice[0] + dice[3];
                soma[3] = dice[1] + dice[2];
                soma[4] = dice[1] + dice[3];
                soma[5] = dice[3] + dice[2];

                perm[0, 0] = soma[0].ToString() + soma[5].ToString();
                perm[0, 1] = soma[0].ToString("X") + soma[5].ToString("X");
                perm[0, 2] = "1234";

                perm[1, 0] = soma[1].ToString() + soma[4].ToString();
                perm[1, 1] = soma[1].ToString("X") + soma[4].ToString("X");
                perm[1, 2] = "1324";

                perm[2, 0] = soma[2].ToString() + soma[3].ToString();
                perm[2, 1] = soma[2].ToString("X") + soma[3].ToString("X");
                perm[2, 2] = "1423";

                //procura por combinacoes duplas.
                for (int i = 0; i < 3; i++)
                {
                    //se as duas partes da string sao iguais, temos uma combinacao dupla.
                    if (perm[i, 1].Substring(0, 1) == perm[i, 1].Substring(1, 1))
                    {

                        doubles[i] = i;
                        d_dice = true;
                    }
                }
                //tamanho maximo que cada coluna tem
                int[] max_size = new int[] { 3, 5, 7, 9, 11, 13, 11, 9, 7, 5, 3 };

                //procura por trilhas que foram dominadas para excluir.
                for (int i = 0; i < 11; i++)
                {
                    if (EnemyBases[i, max_size[i] - 1, 0] != 0 || PlayerBases[i, max_size[i] - 1, 0] != 0)
                    {
                        ValidTrail[i] = 0;
                    }
                }

                //quantidade de alpinistas sendo usados
                switch (ClimbersInUse)
                {
                    case 0:
                        conquer = CanConquer(max_size, false);
                        //se ha bases a serem conquistada
                        if (conquer[11] != 0)
                        {
                            //se eh posssivel conquistar mais de uma base.
                            if (conquer[11] > 1)
                            {
                                int[] moveTrail = TrailOptions(conquer);
                                int permNum = ChoosePermDouble(perm, moveTrail, moveTrail[11]);
                                if (permNum != -1)
                                {
                                    move_ready = true;
                                    comb = permNum;
                                }

                            }
                            //se eh possivel dominar apenas 1 base.
                            if (!move_ready)
                            {
                                //se saiu dados duplos.
                                if (d_dice)
                                {
                                    conquer = CanConquer(max_size, true);
                                    int[] moveTrail = new int[11];
                                    int j = 0;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        if (conquer[i] != 0)
                                        {
                                            moveTrail[j] = i + 2;
                                            j++;
                                        }
                                    }
                                    if (j > 0)
                                    {
                                        int permNum = ChoosePermOne(perm, moveTrail, j);
                                        if (permNum != -1)
                                        {
                                            move_ready = true;
                                            comb = permNum;
                                        }
                                    }
                                }
                                //se nao saiu dados duplos.
                                else
                                {
                                    //int permNum = ChoosePermOne(perm, moveTrail, j);
                                    //escolher a trilha a ser dominada.
                                }
                               
                            }
                        }
                        //se nao havia nenhuma base que pudesse ser conquistada.
                        else
                        {
                            //se ha possibilidade de jogar um dado duplo.
                            if (d_dice)
                            {
                                //procurar a melhor trilha para jogar a combinacao dupla.
                            }
                            else
                            {
                                //procurar a melhor permutacao possivel para jogar.
                            }
                        }
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }


                dice_order = perm[comb, 2];
                dice_value = perm[comb, 1];


                /*
                //parte antiga
                dice_order = "1234";
                l_value = dice[0] + dice[1];
                r_value = dice[2] + dice[3];

                dice_value = l_value.ToString("X");
                dice_value += r_value.ToString("X");
                */
                string rolled = Jogo.Mover(Int32.Parse(currentPlayer[0]), currentPlayer[2], dice_order, dice_value);
                if (rolled != "" && rolled != null)
                {
                    if (rolled[0].ToString() == "E")
                    {
                        MessageBox.Show($"{rolled}");
                    }
                }

                else
                {
                    MessageBox.Show($"{rollDice}");
                }
            }
        }

        public int GetBaseRow(int c_col, int[] max_size)
        {
            for (int i = 0; i < max_size[c_col]; i++)
            {
                if (PlayerBases[c_col, i, 0] != 0)
                {
                    return i+1;
                }
            }
            return 0;
        }

        public bool Stop()
        {
            int stop_factor = 0;

            //se ainda ha alpinistas a serem colocados nao parar
            if (ClimbersInUse < 3)
            {
                return false;
            }

            int[] max_size = new int[] { 3, 5, 7, 9, 11, 13, 11, 9, 7, 5, 3 };
            for (int i = 0; i < ClimbersInUse; i++)
            {
                int c_col, c_row, b_row;
                //ClimberPos ja esta no formato para array, comecando no zero.
                c_col = ClimbersPos[i, 0];
                c_row = ClimbersPos[i, 1] + 1;
                b_row = GetBaseRow(c_col, max_size);
                //se possui bases naquela coluna
                if (b_row != 0)
                {
                    //se a trilha pode ser conquistada, parar!
                    if (c_row == max_size[c_col])
                    {
                        return true;
                    }
                    //se a coluna nao for a 2 ou ou 12
                    if (c_col != 0 && c_col != 10)
                    {
                        //se a falta 1/3 ou menos de trilha, nao parar.
                        int trail_left = max_size[c_col] - c_row;
                        if (trail_left < max_size[c_col]/3)
                        {
                            stop_factor -= 2;
                        }
                        else
                        {
                            //se a distancia percorrida for >= a 1/3 da trilha.
                            int distance = c_row - b_row;
                            if (distance >= max_size[c_col]/3)
                            {
                                stop_factor += 1;
                            }
                            else
                            {
                                stop_factor -= 1;
                            }
                        }
                    }
                    //se for coluna 2 ou 12
                    else
                    {
                        stop_factor += 2;
                    }
                }
                //se nao possui bases na coluna
                else
                {
                    //se o alpinistta moveu 1/3 ou mais da trilha.
                    if (c_row >= max_size[c_col]/3)
                    {
                        stop_factor += 1;
                    }
                    else
                    {
                        stop_factor -= 1;
                    }
                }
            }
            if (stop_factor > 0)
            {
                return true;
            }
            return false;
        }

        public bool IsPlayerTurn()
        {
            string player_turn = Jogo.VerificarVez(gameId);
            if (player_turn != "" && player_turn != null)
            {
                if (player_turn != "ERRO:Partida não está em jogo\r\n")
                {


                    string[] pt = new string[2];
                    pt = player_turn.Split(',');
                    if (pt[0] != "E" && Convert.ToInt32(pt[1]) == Convert.ToInt32(currentPlayer[0]))
                    {
                        PlayerTurn = true;
                    }
                    else
                    {
                        PlayerTurn = false;
                    }
                }
                else
                {
                    PlayerTurn = false;
                    MessageBox.Show("PARTIDA ENCERRADA!");
                    close = true;
                }
            }
            else
            {
                PlayerTurn = false;
            }
            return PlayerTurn;
        }

        //nao sera mais necessario
        public void UpdateBoardInfo()
        {
            string board = Jogo.ExibirTabuleiro(gameId);
            if (board != "" && board != null)
            {
                string[] data = new string[50];
                data = board.Replace("\r", "").Split('\n');
                ClimbersInUse = 0;
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        PlayerBases[i, j, 0] = 0;
                    }
                }
                foreach (string LineData in data)
                {
                    if (LineData != null && LineData != "")
                    {
                        string[] bInfo = new string[4];
                        bInfo = LineData.Split(',');
                        //se eh alpinista
                        if (bInfo[3] == "A")
                        {
                            ClimbersPos[ClimbersInUse, 0] = (Int32.Parse(bInfo[0]) - 2);
                            ClimbersPos[ClimbersInUse, 1] = (Int32.Parse(bInfo[1]) - 1);
                            ClimbersInUse++;
                        }
                        //se eh base
                        else
                        {
                            int col = (Int32.Parse(bInfo[0]) - 2); //a primeira coluna eh o 2.
                            int row = (Int32.Parse(bInfo[1]) - 1); //a primeira linha eh o 1.
                            //atualza a matriz de bases do jogador (usada pelo bot)
                            if (currentPlayer[0] == bInfo[2])
                            {
                                PlayerBases[col, row, 0] = 1;
                            }
                        }
                    }
                }
            }
        }

        public void Init(string[] c_player, int g_id)
        {
            this.currentPlayer = c_player;
            gameId = g_id;
        }
        public void RollDice()
        {
            int playerId = Convert.ToInt32(currentPlayer[0]);
            string playerPassword = currentPlayer[2];
            rollDice = Jogo.RolarDados(playerId, playerPassword);
            
        }
        
        public void FixBases()
        {
            int[] max_size = new int[] { 3, 5, 7, 9, 11, 13, 11, 9, 7, 5, 3 };
            for (int i = 0; i < ClimbersInUse; i++)
            {
                //reseta bases naquela coluna
                for (int j = 0; j < max_size[ClimbersPos[i, 0]]; j++)
                {
                    //se econtrar base na coluna, setar para zero
                    if (PlayerBases[ClimbersPos[i, 0], j, 0] != 0)
                    {
                        PlayerBases[ClimbersPos[i, 0], j, 0] = 0;
                    }
                }
                //adiciona a base na posicao do alpinista
                PlayerBases[ClimbersPos[i, 0], ClimbersPos[i, 1], 0] = 1;
            }
        }

        public void Play()
        {
            playing = true;
            STOP = false;
            RollDice();
            //so tenta mover se nao tiver estourado nos dados.
            if (IsPlayerTurn())
            {
                //UpdateBoardInfo();
                ChooseMove();
                
                //Thread.Sleep(300);
                //UpdateBoardInfo();
                if (STOP)
                {
                    string parar = Jogo.Parar(Int32.Parse(currentPlayer[0]), currentPlayer[2]);
                    FixBases();
                    ClimbersInUse = 0;
                    playing = false;
                    //TO DO: reset variables.
                }
               
            }
            else
            {
                //reset variables
            }

        }
    }
}
