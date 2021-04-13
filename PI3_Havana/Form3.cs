using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace PI3_Havana
{
    public partial class Form3 : Form
    {
        public string[] currentPlayer { get; private set; }
        public int gameId { get; private set; }
        public Form3(string[] inputCurrentPlayer, int inputGameId)
        {
            gameId = inputGameId;
            currentPlayer = inputCurrentPlayer;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isItTurn = Jogo.VerificarVez(gameId);
            MessageBox.Show(isItTurn);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenPawns_Click(object sender, EventHandler e, PaintEventArgs x)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenPawns_Click(object sender, EventArgs e)
        {
            // Get players colors
            Color setPlayerColor(List<Player> inputCurrentPlayers, string[] inputPawn)
            {
                Player currentPlayer = inputCurrentPlayers.Find(x => x.playerId == Convert.ToInt16(inputPawn[2]));
                string inputColor = currentPlayer.playerColor;
                Color playerColor;

                if (inputPawn[3] == "B")
                {
                    if (inputColor == "Vermelho")
                    {
                        playerColor = System.Drawing.Color.Red;
                    }
                    else if (inputColor == "Verde")
                    {
                        playerColor = System.Drawing.Color.Green;
                    }
                    else if (inputColor == "Azul")
                    {
                        playerColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        playerColor = System.Drawing.Color.Yellow;
                    }
                }
                else
                {
                    playerColor = System.Drawing.Color.Black;
                }

                return playerColor;
            }

            List<Player> currentPlayers = Player.buildPlayerList(gameId);


            Board boardTrails = new Board();
            List<Trails> myTrails = boardTrails.createBoard;

            string getBoard = Jogo.ExibirTabuleiro(gameId);

            string[] actualClimbers = getBoard.Replace("\r", "").Split('\n');
            int numberOfClimbers = actualClimbers.Length - 1;
            Climber[] myClimbers = new Climber[numberOfClimbers];
            int count = 0;
            string[] actualPawn;

            for (int i = 0; i < numberOfClimbers; i++)
            {

                Color pawnColor;
                actualPawn = actualClimbers[i].Split(',');
                pawnColor = setPlayerColor(currentPlayers, actualPawn);

                Trails thisTrail = myTrails.Find(x => x.referencePosition == $"{actualPawn[0]},{actualPawn[1]}");
                Climber test = new Climber();

                test.genClimber.Location = test.setClimberLocation(thisTrail.positionX, thisTrail.positionY);
                test.genClimber.ForeColor = pawnColor;
                this.Controls.Add(test.genClimber);
                test.genClimber.Show();
                count++;
            }

        }

        private void lblPawn1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer[0] != null)
            {
                int playerId = Convert.ToInt32(currentPlayer[0]);
                string playerPassword = currentPlayer[2];
                string rollDice = Jogo.RolarDados(playerId, playerPassword);

                if (rollDice[0] != 'E')
                {
                    string[] diceResult = rollDice.Replace("\r", "").Split('\n');

                    lblDie1.Text = $"1: {diceResult[0][1]}";
                    lblDie2.Text = $"2: {diceResult[1][1]}";
                    lblDie3.Text = $"3: {diceResult[2][1]}";
                    lblDie4.Text = $"4: {diceResult[3][1]}";
                } else
                {
                    MessageBox.Show($"{rollDice}");
                }
            }
            else
            {
                MessageBox.Show("There's no player available to roll dice!");
            }
        }

        private void tmrCheckTurn_Tick(object sender, EventArgs e)
        {
            string checkTurn = Jogo.VerificarVez(gameId);
            string[] splitCheckTurn = checkTurn.Split(',');

            if (splitCheckTurn[1] == currentPlayer[0])
            {
                lblCheckTurn.Text = "It is your turn!";
            } 
            else
            {
                lblCheckTurn.Text = $"Player {splitCheckTurn[1]} turn.";
            }
        }

        private void lblCheckTurn_Click(object sender, EventArgs e)
        {

        }

        private void lblPawn3_Click(object sender, EventArgs e)
        {

        }
    }
}
