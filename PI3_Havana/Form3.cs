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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Board newBoard = new Board();
            //newBoard
            //string response = Jogo.ExibirTabuleiro(53);
            //string[] tabuleiro = response.Replace("\n", "").Split(',');
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
            Board boardTrails = new Board();
            List<Trails> myTrails = boardTrails.createBoard;

            string getBoard = Jogo.ExibirTabuleiro(129);

            string[] actualClimbers = getBoard.Replace("\r", "").Split('\n');
            int numberOfClimbers = actualClimbers.Length - 1;
            Climber[] myClimbers = new Climber[numberOfClimbers];
            Color myColor;
            int count = 0;
            string[] actualPawn;
            int adjustLocation = 0;

            for (int i = 0; i < numberOfClimbers; i++)
            {
                actualPawn = actualClimbers[i].Split(',');
                if (Convert.ToInt32(actualPawn[2]) == 168)
                {
                    myColor = System.Drawing.Color.DarkMagenta;
                }
                else if (Convert.ToInt32(actualPawn[2]) == 169)
                {
                    myColor = System.Drawing.Color.AliceBlue;
                }
                else
                {
                    myColor = System.Drawing.Color.GreenYellow;
                }

                Trails thisTrail = myTrails.Find(x => x.referencePosition == $"{actualPawn[0]},{actualPawn[1]}");
                Climber test = new Climber();
                test.generateNewClimbers(thisTrail.positionX + adjustLocation, thisTrail.positionY);
                test.genClimber.ForeColor = myColor;
                count++;
                adjustLocation += 5;
            }

        }

        private void lblPawn1_Click(object sender, EventArgs e)
        {

        }
    }
}
