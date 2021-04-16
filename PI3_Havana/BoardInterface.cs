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
    public partial class BoardInterface : Form
    {
        public string[] currentPlayer { get; private set; }
        public int gameId { get; private set; }

        string path;
        public bool IsLinux()
        {
            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            if (pid == PlatformID.Unix)
            {
                return true;
            }
            return false;
        }
            public void SpawnPawn()
        {
            int bottom = 111;
            int left_start = 433;
   
            //o script fica na pasta raiz do projeto. (nao no bin/debug)
            //depois corrigir os paths pelo script e apagar aqui.
            if (IsLinux())
            {
                path = "./Resources";
            }
            else
            {
                path = "../../Resources";
            }

            //teste picturebox runtime
            PictureBox pb = new PictureBox()
            {
                Name = "Picture",
                Size = new Size(25, 25),
                Location = new Point(bottom, left_start),
                Image = Image.FromFile(path + "/full.png"),
            };

            this.Controls.Add(pb);
            pb.BringToFront();
            pb.BackColor = Color.Transparent;
        }
        public BoardInterface(string[] inputCurrentPlayer, int inputGameId)
        {
            gameId = inputGameId;
            currentPlayer = inputCurrentPlayer;
        
            InitializeComponent();
            SpawnPawn();
        }

        private void BoardInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer[0] != null)
            {
                int playerId = Convert.ToInt32(currentPlayer[0]);
                string playerPassword = currentPlayer[2];
                string rollDice = Jogo.RolarDados(playerId, playerPassword);

                if (rollDice[0] != 'E')
                {
                    string[] diceResult = rollDice.Replace("\r", "").Split('\n');

                    dice1.Image = Image.FromFile(path + "/dice" + diceResult[0][1].ToString() + ".png");
                    dice2.Image = Image.FromFile(path + "/dice" + diceResult[1][1].ToString() + ".png");
                    dice3.Image = Image.FromFile(path + "/dice" + diceResult[2][1].ToString() + ".png");
                    dice4.Image = Image.FromFile(path + "/dice" + diceResult[3][1].ToString() + ".png");
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
    }
}
