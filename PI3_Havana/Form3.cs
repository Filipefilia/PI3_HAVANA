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

        private void btnGenPawns_Click(object sender, EventArgs e)
        {
            /*Label[] newPawns = new Label[10];

            Label tempLabel1 = new Label();
            Label tempLabel2 = new Label();
            Label tempLabel3 = new Label();

            tempLabel1.Location = lblPawn1.Location;
            tempLabel1.Visible = true;
            tempLabel1.Text = "IM HERE";
            tempLabel1.Size = new System.Drawing.Size(77, 21);
            Form3.ActiveForm.Controls.Add(tempLabel1);
            tempLabel1.BackColor = Color.Black;
            tempLabel2.Location = lblPawn2.Location;
            tempLabel3.Location = lblPawn1.Location;

            tempLabel1.ForeColor = Color.Magenta;

            newPawns.Append(tempLabel1);
            newPawns.Append(tempLabel2);
            newPawns.Append(tempLabel3);

            tempLabel1.Show();
            tempLabel2.Show();
            tempLabel3.Show();*/
            Climber myNewClimber = new Climber();
            myNewClimber.generateNewClimbers();
        }
    }
}
