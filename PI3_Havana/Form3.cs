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
        public int gameId { get; private set; }
        public Form3(int inputGameId)
        {
            gameId = inputGameId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Board newBoard = new Board();
            //newBoard
            string[] tabuleiro = { "12,1", "8,6", "7,10" };
            Label[] currentPawns = { lblPawn1, lblPawn2, lblPawn3};
            var i = 0;

            foreach (string map in tabuleiro)
            {
                string[] current = map.Split(',');
                Trails lambda = newBoard.createBoard.Find(x => x.referencePosition == $"{current[0]},{current[1]}");
                Point newLocation = new Point(
                    lambda.positionX,
                    lambda.positionY
                );

                currentPawns[i].Location = newLocation;
                currentPawns[i].ForeColor = Color.Red;
                i++;
            }
            

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
            Color setPlayerColor(List<Player> inputCurrentPlayers, int inputPlayerId)
            {
                Player currentPlayer = inputCurrentPlayers.Find(x => x.playerId == inputPlayerId);
                string inputColor = currentPlayer.playerColor;
                Color playerColor;

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
                else if (inputColor == "Amarelo")
                {
                    playerColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    playerColor = System.Drawing.Color.White;
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
                pawnColor = setPlayerColor(currentPlayers, Convert.ToInt32(actualPawn[2]));

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
    }
}
