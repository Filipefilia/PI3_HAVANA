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

        public Form1()
        {
            InitializeComponent();

            //Label .dll version
            lblVersion.Text = Jogo.Versao.ToString();
            
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

                //Check if got an error message
                string checkIfError = response.Substring(0, 4);

                //Check if the message got a known error
                if (checkIfError == "ERRO")
                {
                    //Shows returned errors
                    MessageBox.Show(response);
                }
                else
                {
                    //Shows a message box when successful
                    response = "New game created\nID: " + response;
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
                
                //Check if got an error message
                string checkIfError = response.Substring(0, 4);

                //Check if the message got a known error
                if (checkIfError == "ERRO")
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
            /*try
            {
                //Gets a datagrid row and save its id for enter in a new game
                var selectedRow = dgrLobby.SelectedRows[0].DataBoundItem as Game;
                int selectedGameId = selectedRow.id;

                //Gets list of players in selected game
                string response = Jogo.ListarJogadores(selectedGameId);

                //Check if got an error message
                string checkIfError = response.Substring(0, 4);

                //Check if the message got a known error
                if (checkIfError == "ERRO")
                {
                    //Shows returned errors
                    MessageBox.Show(response);
                }
                else
                {
                    //Construct the list of players and shows it
                    string[] getListPlayers = response.Replace("\r", "").Split('\n');
                    string[] listPlayers;
                    ListBox lbListPlayers = new ListBox();
                    foreach(string player in getListPlayers)
                    {
                        listPlayers = player.Split(',');
                        lbListPlayers.Items.Add(listPlayers);
                    }
                    //lbListPlayers.Show();
                    MessageBox.Show(Convert.ToString(listPlayers));
                }
            }
            catch (Exception)
            {

                //Default message for unknown errors
                MessageBox.Show("Couldn't perform this action, please try again.");
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Refreshes datagrid Lobby every 5 seconds
            dgrLobby.DataSource = null;
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
                
                //Check if got an error message
                string checkIfError = response.Substring(0, 4);
                
                //Check if the message got a known error
                if (checkIfError == "ERRO")
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
    }
}
