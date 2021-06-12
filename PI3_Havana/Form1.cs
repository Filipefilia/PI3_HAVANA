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
    public partial class Form1 : Form
    {
        Session currentSession = new Session();
        //para eventuais problemas de compatibilidades entre linux e windows.
        //botar outros OS em case, retornar um int;
        public bool myOS()
        {
            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            if (pid == PlatformID.Unix)
            {
                return true;
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            //tava crashando quando mudava pelas opcoes..
            this.Icon = new Icon("../../Resources/pawn_pink.ico");

            //Label .dll version
            lblVersion.Text = "DLL V" + Jogo.Versao.ToString();


						/*
            if (myOS())
            {
                OS.Text = "OS: GNU/Linux";
            }
            else
            {
                OS.Text = "OS: Windows";
            }
						*/


            //Lobby DataGrid
            dgrLobby.DataSource = currentSession.currentList;
            dgrLobby.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets text boxes content to create a new game
                string getGameName = txtGameName.Text;
                string getGamePassword = txtInputPassword.Text;
                string response = Jogo.CriarPartida(getGameName, getGamePassword);

                //Check if the message got a known error
                if (response[0] == 'E')
                {
                    //Shows returned errors
                    MessageBox.Show(response);
                }
                else
                {
                    //Shows a message box when successful
                    response = $"New game created\nID: {response}";
                    MessageBox.Show(response);
                }
            }
            catch (Exception)
            {
                //Default message for unknown errors
                MessageBox.Show("Couldn't perform this action, please try again.");
            }
            finally
            {
                txtGameName.Clear();
                txtInputPassword.Clear();
                Session currentSession = new Session();
                dgrLobby.DataSource = currentSession.currentList;
            }
        }

        private void btnEnterGame_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets a datagrid row and save its id for enter in a new game
                var selectedRow = dgrLobby.SelectedRows[0].DataBoundItem as Game;
                int selectedGameId = selectedRow.id;

                //Gets player name and password for the chosen game
                string playerName = txtPlayerName.Text;
                string gamePassword = txtPasswordGame.Text;

                //Enters in a new game and receives user information
                string response = Jogo.EntrarPartida(selectedGameId, playerName, gamePassword);

                //Check if the message got a known error
                if (response[0] == 'E')
                {
                    //Shows returned errors
                    MessageBox.Show(response);
                }
                else
                {
                    //Saves the information in an array and sets it to textboxes
                    string[] playerInfo = response.Split(',');
                    txtPlayerId.Text = playerInfo[0];
                    txtPlayerPassword.Text = playerInfo[1];
                    txtPlayerCollor.Text = playerInfo[2];
                    txtPlayerName.Text = playerName;

                    //Shows a message box when successful
                    response = "You've entered in a new game match.";
                    MessageBox.Show(response);
                }

            }
            catch (Exception)
            {
                //Default message for unknown errors
                MessageBox.Show("Couldn't perform this action, please try again.");
            }
            finally
            {
                //Clear text boxes
                txtPlayerName.Clear();
                txtPasswordGame.Clear();
            }
        }

        private void lvlVersion_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void listPlayers_Click(object sender, EventArgs e)
        {

        }

        private void listPlayers_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnListGames_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgrLobby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelectGame_Click(object sender, EventArgs e)
        {
            var selectedRow = dgrLobby.SelectedRows[0].DataBoundItem as Game;
            int selectedGameId = selectedRow.id;

            List<Player> currentPlayers = Player.buildPlayerList(selectedGameId);

            if (currentPlayers != null)
            {
                DataGrid dgrPlayers = new DataGrid();
                dataGridView1.DataSource = currentPlayers;
                dataGridView1.Show();
            }
            else
            {
                MessageBox.Show("No players in this game.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Refreshes datagrid Lobby every 5 seconds
            Session currentSession = new Session();
            dgrLobby.DataSource = currentSession.currentList;
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Get parameters
                int playerId = Convert.ToInt16(txtPlayerId.Text);
                string playerPassword = txtPlayerPassword.Text;

                //Send initiante game command
                string response = Jogo.IniciarPartida(playerId, playerPassword);

                //Check if the message got a known error
                if (response[0] == 'E')
                {
                    //Shows returned errors
                    MessageBox.Show(response);
                }
                else
                {
                    //Shows successful message
                    MessageBox.Show("Game has started");
                }
            }
            catch (Exception)
            {
                //Default message for unknown errors
                MessageBox.Show("Couldn't perform this action, please try again.");
            }
        }

        private void lbGameName_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordEnter_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayerPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayerID_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCollor_Click(object sender, EventArgs e)
        {

        }

        private void lblGameId_Click(object sender, EventArgs e)
        {

        }

        private void txtGameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void sessionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {

        }

        private void lblDie2_Click(object sender, EventArgs e)
        {

        }

        private void btnGetBoard_Click(object sender, EventArgs e)
        {

            int gameId;

            string[] currentPlayer = { txtPlayerId.Text, txtPlayerName.Text, txtPlayerPassword.Text, txtGameId.Text, txtPlayerCollor.Text };

            
            try
            {
                gameId = Convert.ToInt32(currentPlayer[3]);
            }
            catch
            {
                var selectedRow = dgrLobby.SelectedRows[0].DataBoundItem as Game;
                gameId = selectedRow.id;
            }
            string pTurn = Jogo.VerificarVez(gameId);
            if (pTurn != "ERRO:Partida não está em jogo\r\n")
            {
                this.Hide();
                //Form3 board = new Form3(currentPlayer, gameId);
                BoardInterface board = new BoardInterface(currentPlayer, gameId, tb_botName.Text);
                board.ShowDialog();
            }
            else
            {
                MessageBox.Show("A partida não foi iniciada!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refreshes datagrid Lobby
            Session currentSession = new Session();
            dgrLobby.DataSource = currentSession.currentList;
        }

        private void tb_botName_MouseClick(object sender, MouseEventArgs e)
        {
            tb_botName.Text = "";
        }
    }
}
