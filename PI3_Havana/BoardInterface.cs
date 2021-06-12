using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace PI3_Havana
{
    public partial class BoardInterface : Form
    {
        //0=PlayerId, 1=PlayerName, 2=PlayerPassword, 3=GameId, 4=PlayerColor
        public string[] currentPlayer { get; private set; }
        public int gameId { get; private set; }

        BotAI botAI = new BotAI();

        int climbers = 3;
        int playersInGame = 0;
        bool playerTurn;

        int[,,] playerBases = new int[11,13,1];
        public int[,,] enemyBases = new int[11, 13, 1];

        bool[] climbersInUse = new bool[] { false, false, false };
        int[,] climbersPos = new int[3, 2];
        string[] permutations = new string[6];

        //poderia colocar um dicionario com o valor sendo uma array? (fazer teste)
        //[player][id, name, color]
        public string[,] playersData = new string[4, 3];

        //{player id, color}
        public Dictionary<int, string> PlayersColor = new Dictionary<int, string>();

        public Dictionary<string, int> ColorRank = new Dictionary<string, int>();

        string bot;
        string res_path = "../../Resources/";
        string old_log = "";
        string new_log = "";
        string old_brd = "";
        string new_brd = "";
        string old_pt = "";
        string new_pt = "";

        //3D matrix 11 colunas, 13 linhas (max), 4 sprites.
        public PictureBox[,,] bases = new PictureBox[11, 13, 4];
        
        public void CreateMatrix()
        {
            foreach (PictureBox picbox in this.Controls.OfType<PictureBox>().Where(pb => pb.Name.StartsWith("bs_")))
            {
                int x, c_len, r_len, i, j, k = 0;
                string sprite_pos;

                //Verifica se o numero da coluna e linha tem 1 ou 2 caracteres.
                //tenta converter para int, se for '_' entao o numero possui 1 caractere.
                // ex: bs_c1_r1_tl
                // ex: bs_c12r10br
                if (Int32.TryParse(picbox.Name.Substring(5, 1), out x))
                {
                    c_len = 2;
                }
                else
                {
                    c_len = 1;
                }

                if (Int32.TryParse(picbox.Name.Substring(8, 1), out x))
                {
                    r_len = 2;
                }
                else
                {
                    r_len = 1;
                }

                //pega a  coluna e a linha pelo nome do PictureBox "bs_c[num]r[num][pos]"
                i = Int32.Parse(picbox.Name.Substring(4, c_len)) - 1;
                j = Int32.Parse(picbox.Name.Substring(7, r_len)) - 1;

                //pega o final do nome para comparar e adicionar corretamente na matriz.
                sprite_pos = picbox.Name.Substring(9, 2);

                switch (sprite_pos)
                {
                    case "tl":
                        k = 0;
                        break;
                    case "tr":
                        k = 1;
                        break;
                    case "bl":
                        k = 2;
                        break;
                    case "br":
                        k = 3;
                        break;
                    default:
                        MessageBox.Show("ERROR: INCORRECT NAME FORMAT!");
                        break;
                }
                bases[i, j, k] = picbox;
            }
        }

        public void HideBases()
        {
            int[] max_size = new int[] {3, 5, 7, 9, 11, 13, 11, 9, 7, 5, 3};
            //i = coluna, j = linha, k = sprite.
            int i, j, k;

            for(i = 0; i < 11; i++)
            {
                for (j = 0; j < max_size[i]; j++)
                {
                    for (k = 0; k < 4; k++)
                    {
                        bases[i, j, k].Hide();
                    }
                }

            }
        }

        public void CreateColorDict()
        {
            ColorRank.Add("red", 4);
            ColorRank.Add("blue", 3);
            ColorRank.Add("green", 2);
            ColorRank.Add("yellow", 1);

            string color = "pink";
            for (int i = 0; i < playersInGame; i++)
            {
                //fiquei com medo de mudar o nome do sprite e cagar tudo
                //depois tentar mudar o nome e apagar esse switch.
                switch (playersData[i, 2])
                {
                    case "Vermelho":
                        color = "red";
                        break;
                    case "Azul":
                        color = "blue";
                        break;
                    case "Amarelo":
                        color = "yellow";
                        break;
                    case "Verde":
                        color = "green";
                        break;
                }
                //debug
                if (color != "pink")
                {
                    PlayersColor.Add(Int32.Parse(playersData[i, 0]), color);
                }
                else
                {
                    MessageBox.Show("ERROR DISPLAYING BASE COLORS");
                }
            }
        }

        /* retorna a cor em ingles e minusculo
        public string GetPlayerColorEng(string id)
        {
            string color = PlayersColor[Int32.Parse(id)];
            return color;

        }
        */

        public string GetPlayerColor(string id)
        {
            //pensar em uma maneira de "debug" melhor.
            string color = "rosa";
            for (int i = 0; i < playersInGame; i++)
            {
                //Parse para evitar bugs com caracteres especiais
                if (Int32.Parse(playersData[i, 0]) == Int32.Parse(id))
                {
                    color = playersData[i, 2];
                    break;
                }
            }
            return color.ToLower();
        }

        public void UpdateBus()
        {
            switch (climbers)
            {
                case 0:
                    bus_climber1.Hide();
                    bus_climber2.Hide();
                    bus_climber3.Hide();
                    break;
                case 1:
                    bus_climber1.Show();
                    bus_climber2.Hide();
                    bus_climber3.Hide();
                    break;
                case 2:
                    bus_climber1.Show();
                    bus_climber2.Show();
                    bus_climber3.Hide();
                    break;
                case 3:
                    bus_climber1.Show();
                    bus_climber2.Show();
                    bus_climber3.Show();
                    break;
                default:
                    break;
            }
           
            string DriverColor;
            string[] pTurn = new string[2];
            string verificaVez;
            verificaVez = Jogo.VerificarVez(gameId);
            //evitar crash quando o jogo termina.
            if (verificaVez != "" && verificaVez != null && verificaVez != "ERRO:Partida não está em jogo\r\n")
            {

                if (verificaVez[0] != 'E' && verificaVez != "")
                {
                    pTurn = verificaVez.Split(',');
                    //para evitar crash caso a string venha vazia (fazer mais testes/mudar esquema)
                    if (pTurn[1] != null && pTurn[1] != "")
                    {
                        DriverColor = GetPlayerColor(pTurn[1]);
                        driver.Image = Image.FromFile(res_path + "driver_" + DriverColor + ".png");
                    }
                    else
                    {
                        MessageBox.Show("ERROR DISPLAYING BUS DRIVERS!");
                    }
                }
            }
        }

        public void GetPlayersData()
        {
            string[] Data = new string[4];
            Data = Jogo.ListarJogadores(gameId).Replace("\r", "").Split('\n');
            playersInGame = Data.Count(s => s != null) - 1;
            for (int i = 0; i < playersInGame; i++)
            {
                string[] playerInfo = new string[3];
                playerInfo = Data[i].Split(',');
                for (int j = 0; j < 3; j++)
                {
                    playersData[i, j] = playerInfo[j];
                }
            }
        }

        public int[] GetPixelPos(string[] baseInfo)
        {
            int[] vector2 = new int[2];
            int posX = 83;    // posX e posY = posicao inicial (primeira base)
            int posY = 447;
            int offsetX = 60;  //move para a direita.
            int offsetY = -34; //move para cima.

            vector2[0] = posX + (Int32.Parse(baseInfo[0]) -2) * offsetX;
            vector2[1] = posY + (Int32.Parse(baseInfo[1]) -1) * offsetY;

            return vector2;

        }

        public void MoveClimber(string[] baseInfo)
        {
            int[] pixelPos = new int[2];
            pixelPos = GetPixelPos(baseInfo);
            //DEBUGAR MELHOR
            if (climbersInUse[0] == true && climbersInUse[1] == true && climbersInUse[2] == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    climbersInUse[i] = false;
                }
            }

            if (!climbersInUse[0])
            {
                mtn_climber1.Location = new Point(pixelPos[0], pixelPos[1]);
                mtn_climber1.Show();
                climbersInUse[0] = true;
                climbersPos[0, 0] = Int32.Parse(baseInfo[0]);
                climbersPos[0, 1] = Int32.Parse(baseInfo[1]);
            }
            else
            {
                if (!climbersInUse[1])
                {
                    mtn_climber2.Location = new Point(pixelPos[0], pixelPos[1]);
                    mtn_climber2.Show();
                    climbersInUse[1] = true;
                    climbersPos[1, 0] = Int32.Parse(baseInfo[0]);
                    climbersPos[1, 1] = Int32.Parse(baseInfo[1]);
                }
                else
                {
                    mtn_climber3.Location = new Point(pixelPos[0], pixelPos[1]);
                    mtn_climber3.Show();
                    climbersInUse[2] = true;
                    climbersPos[1, 0] = Int32.Parse(baseInfo[0]);
                    climbersPos[1, 1] = Int32.Parse(baseInfo[1]);
                }
            }
            climbers--;
        }

        public void SpawnBases(string boardData)
        {
            //evitar crash caso a string venha vazia.
            if (boardData != "" && boardData != null)
            {
                // bases[coluna, linha, cores + numero de jogadores na base]
                string[,,] c_bases = new string[11, 13, 5];
                // 11*4 + 3 = 47 bases possiveis.
                string[] data = new string[50];
                data = boardData.Replace("\r", "").Split('\n');
                //reseta para nao perder a contagem correta!
                climbers = 3;
                //reseta variaveis do jogador.
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        playerBases[i, j, 0] = 0;
                    }
                }
                //reseta variaveis dos inimigos.
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        enemyBases[i, j, 0] = 0;
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
                            MoveClimber(bInfo);
                        }
                        else
                        {
                       
                            int col = (Int32.Parse(bInfo[0]) - 2); //a primeira coluna eh o 2.
                            int row = (Int32.Parse(bInfo[1]) - 1); //a primeira linha eh o 1.
                            //atualiza a matriz de bases do jogador (usada pelo bot)
                            if (currentPlayer[0] == bInfo[2])
                            {
                                playerBases[col, row, 0] = 1; 
                            }
                            else
                            {
                                enemyBases[col, row, 0] = 1;
                            }
                           

                            //se ja tiver jogadores naquela base
                            if (c_bases[col, row, 4] != "" && c_bases[col, row, 4] != null)
                            {
                                string[] p_colors = new string[4];
                                switch (Int32.Parse(c_bases[col, row, 4]))
                                {
                                    case 1:
                                        //divide o circulo ao meio, segundo a ordem de prioridade
                                        if (ColorRank[c_bases[col, row, 0]] > ColorRank[PlayersColor[Int32.Parse(bInfo[2])]])
                                        {
                                            p_colors[0] = c_bases[col, row, 0];
                                            p_colors[1] = PlayersColor[Int32.Parse(bInfo[2])];
                                        }
                                        else
                                        {
                                            p_colors[0] = PlayersColor[Int32.Parse(bInfo[2])];
                                            p_colors[1] = c_bases[col, row, 0];
                                            
                                        }
                                        //refazer essas repeticoes com for?
                                        bases[col, row, 0].Image = Image.FromFile(res_path + p_colors[0] + "_tl.png");
                                        bases[col, row, 1].Image = Image.FromFile(res_path + p_colors[0] + "_tr.png");
                                        bases[col, row, 2].Image = Image.FromFile(res_path + p_colors[1] + "_bl.png");
                                        bases[col, row, 3].Image = Image.FromFile(res_path + p_colors[1] + "_br.png");

                                        bases[col, row, 0].Show();
                                        bases[col, row, 1].Show();
                                        bases[col, row, 2].Show();
                                        bases[col, row, 3].Show();

                                        //Atualiza informacoes sobre as casas (cores e numero de bases)
                                        c_bases[col, row, 4] = (Int32.Parse(c_bases[col, row, 4]) + 1).ToString();
                                        c_bases[col, row, 0] = p_colors[0];
                                        c_bases[col, row, 1] = p_colors[1];

                                        break;
                                    case 2:
                                        //se a cor nova tiver valor de prioridade maior que a mais alta.
                                        if (ColorRank[c_bases[col, row, 0]] < ColorRank[PlayersColor[Int32.Parse(bInfo[2])]])
                                        {
                                            p_colors[0] = PlayersColor[Int32.Parse(bInfo[2])];
                                            p_colors[1] = c_bases[col, row, 0];
                                            p_colors[2] = c_bases[col, row, 1];
                                        }
                                        else
                                        {
                                            //se a cor nova tiver valor de prioridade mais alta que a segunda.
                                            if (ColorRank[c_bases[col, row, 1]] < ColorRank[PlayersColor[Int32.Parse(bInfo[2])]])
                                            {
                                                p_colors[0] = c_bases[col, row, 0];
                                                p_colors[1] = PlayersColor[Int32.Parse(bInfo[2])];
                                                p_colors[2] = c_bases[col, row, 1];
                                            }
                                            else
                                            {
                                                p_colors[0] = c_bases[col, row, 0];
                                                p_colors[1] = c_bases[col, row, 1];
                                                p_colors[2] = PlayersColor[Int32.Parse(bInfo[2])];
                                            }
                                        }
                                        bases[col, row, 0].Image = Image.FromFile(res_path + p_colors[0] + "_tl.png");
                                        bases[col, row, 1].Image = Image.FromFile(res_path + p_colors[0] + "_tr.png");
                                        bases[col, row, 2].Image = Image.FromFile(res_path + p_colors[1] + "_bl.png");
                                        bases[col, row, 3].Image = Image.FromFile(res_path + p_colors[2] + "_br.png");

                                        bases[col, row, 0].Show();
                                        bases[col, row, 1].Show();
                                        bases[col, row, 2].Show();
                                        bases[col, row, 3].Show();
                                        //atualiza o numero de bases na casa
                                        c_bases[col, row, 4] = (Int32.Parse(c_bases[col, row, 4]) + 1).ToString();
                                        break;
                                    case 3:
                                        //segundo a ordem de prioridade da pra prever a forma que ficaria com 4 bases.
                                        bases[col, row, 0].Image = Image.FromFile(res_path + "red_tl.png");
                                        bases[col, row, 1].Image = Image.FromFile(res_path + "blue_tr.png");
                                        bases[col, row, 2].Image = Image.FromFile(res_path + "green_bl.png");
                                        bases[col, row, 3].Image = Image.FromFile(res_path + "yellow_br.png");

                                        bases[col, row, 0].Show();
                                        bases[col, row, 1].Show();
                                        bases[col, row, 2].Show();
                                        bases[col, row, 3].Show();
                                        break;
                                }
                            }
                            else
                            {
                                //adicionar a primeira base normalmente
                                string[] sprite_pos = new string[] {"tl", "tr", "bl", "br"};
                                for (int i = 0; i < 4; i++)
                                {
                                    bases[col, row, i].Image = Image.FromFile(res_path + PlayersColor[Int32.Parse(bInfo[2])] + "_" + sprite_pos[i] + ".png");
                                    bases[col, row, i].Show();
                                }
                                c_bases[col, row, 4] = "1";
                                c_bases[col, row, 0] = PlayersColor[Int32.Parse(bInfo[2])];
                            }
                        }
                    }
                     else 
                    {
                        break;
                    }
                }
                //atualiza as bases para o botAI
                if (bot == "pc")
                {
                    botAI.EnemyBases = enemyBases;
                    botAI.PlayerBases = playerBases;
                }
                
            }
        }

        public void HideClimbers()
        {
            mtn_climber1.Hide();
            mtn_climber2.Hide();
            mtn_climber3.Hide();
        }

        //Verifica se houve alguma mudança e atualiza o tabuleiro.
        public void UpdateBoard()
        {
            //se a vez do jogador mudar, resetar os alpinistas.
            //Thread.Sleep(300);
            new_pt = Jogo.VerificarVez(gameId);
            if (new_pt != old_pt)
            {
                //reseta variaveis dos alpinistas.
                climbers = 3;//apagar? ja ocorre em SpawnClimbers.
                for (int i = 0; i < 3; i++)
                {
                    climbersInUse[i] = false;
                }
                old_pt = new_pt;
                if (new_pt != "ERRO:Partida não está em jogo\r\n")
                {


                    string[] pt = new string[2];
                    pt = new_pt.Split(',');
                    if (pt[0] != "E" &&  bot != "player" && bot != "spec")
                    {
                        if (Convert.ToInt32(pt[1]) == Convert.ToInt32(currentPlayer[0]))
                        {
                            //vez da ai jogar
                            playerTurn = true;
                        }
                    }
                }
                else
                {
                    refreshBoard.Stop();
                    playerTurn = false;
                    Application.Exit();
                }
            }
            HideClimbers();
            UpdateBus();
            //evitar ter que aguardar + 2500 milisegundos para atualizar.
            //precisa mesmo? (testar)
            //Thread.Sleep(300);
            //mexe nas bases caso haja necessidade.
            new_brd = Jogo.ExibirTabuleiro(gameId);
            if (new_brd != old_brd)
            {
                HideBases();
                HideClimbers();
                SpawnBases(new_brd);
                UpdateBus();
                old_brd = new_brd;
            }
            //Thread.Sleep(300);
            //mexe no log caso haja necessidade.
            new_log = Jogo.ExibirHistorico(gameId);
            if (old_log != new_log)
            {
                UpdateLog(new_log);
                old_log = new_log;
            }

        }

        public int GetClimberCount()
        {
            int clb = 0;
            for (int i = 0; i < 3; i++)
            {
                if (climbersInUse[i])
                {
                    clb++;
                }
            }
            return clb;
        }

        public void BotTurn()
        {
            if (botAI.close)
            {
                Application.Exit();
            }
            while (playerTurn)
            {
                UpdateBoard();
                botAI.Play();
                
                if (!botAI.IsPlayerTurn())
                {
                    playerTurn = false;
                }
            }
            UpdateBoard();
        }
        public void ChangeIcon(string id)
        {
            //evitar crash para jogos em andamento.
            if (id != null && id != "")
            {
                string color = PlayersColor[Int32.Parse(id)];
                this.Icon = new Icon(res_path + "pawn_" + color + ".ico");
            }
        }

        public void MakeGUI(string user)
        {
            if (user != "player")
            {
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    btn.Hide();
                }
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Hide();
                }
                dice1.Hide();
                dice2.Hide();
                dice3.Hide();
                dice4.Hide();
            }
            else
            {
                lb_log.Hide();
            }
            lb_user.Text = "User: " + user;
        }

        public void ChoosePlayer()
        {
            switch (bot)
            {
                case "player":
                    break;
                case "random":
                    break;
                case "spec":
                    bot = "spec";
                    break;
                default:
                    bot = "pc";
                    break;
            }
        }

        public void UpdateLog(string c_log)
        {
            if (c_log != "" && c_log != null)
            {
                string[] log = c_log.Replace("\r", "").Split('\n');
                int max_size;
                if (log.Length > 6)
                {
                    max_size = 6;
                }
                else
                {
                    max_size = log.Length;
                }
                //nao muito eficiente, mas pouca dor de cabeca
                lb_log.Items.Clear();

                for (int i = 0; i < max_size; i++)
                {
                    lb_log.Items.Add(log[i]);
                }
            }
        }

        public BoardInterface(string[] inputCurrentPlayer, int inputGameId, string botName)
        {
            gameId = inputGameId;
            currentPlayer = inputCurrentPlayer;
            bot = botName;
            //nao mudar a ordem!
            InitializeComponent();
            GetPlayersData();
            CreateColorDict();
            CreateMatrix();
            ChangeIcon(currentPlayer[0]);
            //alguns repetidos em UpdateBoard, mas para aparecer correto em jogos em andamento.
            //talvez possa retirar alguns com a logica nova, testar..
            HideBases();
            HideClimbers();
            ChoosePlayer();
            MakeGUI(bot);
            botAI.Init(currentPlayer, gameId);
            UpdateBus();
            UpdateBoard();
            refreshBoard.Start();
        }

        private void BoardInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PBRollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer[0] != null)
            {
                int playerId = Convert.ToInt32(currentPlayer[0]);
                string playerPassword = currentPlayer[2];
                string rollDice = Jogo.RolarDados(playerId, playerPassword);
                MessageBox.Show($"{rollDice}");

                if (rollDice[0] != 'E')
                {
                    string[] diceResult = rollDice.Replace("\r", "").Split('\n');

                    dice1.Image = Image.FromFile(res_path + "dice" + diceResult[0][1].ToString() + ".png");
                    dice2.Image = Image.FromFile(res_path + "dice" + diceResult[1][1].ToString() + ".png");
                    dice3.Image = Image.FromFile(res_path + "dice" + diceResult[2][1].ToString() + ".png");
                    dice4.Image = Image.FromFile(res_path + "dice" + diceResult[3][1].ToString() + ".png");

                    permutations[0] = diceResult[0][1].ToString() + " e " + diceResult[1][1].ToString() + " // " + diceResult[2][1].ToString() + " e " + diceResult[3][1].ToString();
                    permutations[1] = diceResult[0][1].ToString() + " e " + diceResult[2][1].ToString() + " // " + diceResult[1][1].ToString() + " e " + diceResult[3][1].ToString();
                    permutations[2] = diceResult[1][1].ToString() + " e " + diceResult[2][1].ToString() + " // " + diceResult[0][1].ToString() + " e " + diceResult[3][1].ToString();

                }
                else
                {
                    MessageBox.Show($"{rollDice}");
                }
            }
            else
            {
                MessageBox.Show("There's no player available to roll dice!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gameData;
            gameData = Jogo.ListarJogadores(gameId);
            MessageBox.Show(gameData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string showBoard;
            showBoard = Jogo.ExibirTabuleiro(gameId);
            MessageBox.Show(showBoard);
        }

        private void tb_dices_Click(object sender, EventArgs e)
        {
            tb_dices.Clear();
        }

        private void tb_trails_Click(object sender, EventArgs e)
        {
            tb_trails.Clear();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            
            string mover = Jogo.Mover(Int32.Parse(currentPlayer[0]), currentPlayer[2], tb_dices.Text, tb_trails.Text);

            if (mover == "")
            {
                MessageBox.Show("Moveu!");
                UpdateBoard();
            }
            else
            {
                MessageBox.Show($"{mover}");
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            string parar = Jogo.Parar(Int32.Parse(currentPlayer[0]), currentPlayer[2]);
            if (parar == "")
            {
                MessageBox.Show("Passou a vez!");
            }
            else
            {
                MessageBox.Show($"{parar}");
            }
            UpdateBoard();
        }

        private void refreshBoard_Tick(object sender, EventArgs e)
        {
            //atualiza o tabuleiro a cada 2500 milisegundos.
       
            if (bot == "player" || bot == "spec")
            {
                UpdateBoard();
            }
            else
            {
                if (botAI.IsPlayerTurn() && !botAI.playing)
                {
                    playerTurn = true;
                }

                if (!botAI.playing)
                {
                    BotTurn();
                }
                else
                {
                    UpdateBoard();
                }
            } 
        }

        private void btn_show_hist_Click(object sender, EventArgs e)
        {
            string hist = Jogo.ExibirHistorico(gameId);
            MessageBox.Show($"{hist}");
        }

        private void btn_perm_Click(object sender, EventArgs e)
        {
            string perm = permutations[0] + "\n" + permutations[1] + "\n" + permutations[2];
            MessageBox.Show($"{perm}");

        }
    }
}
