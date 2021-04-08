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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGetBoard_Click(object sender, EventArgs e)
        {
            string player = Jogo.ListarJogadores(53);
            string[] playerInfo = player.Split(',');

            string currentBoard = Jogo.ExibirTabuleiro(53);
            string[] currentBoardArray = currentBoard.Split(',');
            int trilha = Convert.ToInt16(currentBoardArray[0]) - 2;
            int positicao = Convert.ToInt16(currentBoardArray[1]);

            Control info = tableLayoutPanel1.GetControlFromPosition(trilha, positicao);

            switch (playerInfo[2])
            {
                case "Vermelho":
                    info.BackColor = Color.Red;
                    break;
                case "Azul":
                    info.BackColor = Color.Blue;
                    break;
                case "Green":
                    info.BackColor = Color.Green;
                    break;
                default:
                    info.BackColor = Color.White;
                    break;
            }
            
            //this
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
