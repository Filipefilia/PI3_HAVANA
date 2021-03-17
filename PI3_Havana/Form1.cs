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
        public Form1()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.Versao.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T"); 
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');
            for (int i = 0; i < linha.Length; i++) { 
                listGames.Items.Add(linha[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listPlayers.Items.Clear();
            string idPartida = listGames.SelectedItem.ToString();
            string[] lista = idPartida.Split(',');
            int id = Convert.ToInt32(lista[0]);
            string retorno = Jogo.ListarJogadores(id);
            //retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');
            for (int i = 0; i < linha.Length; i++)
            {
                listPlayers.Items.Add(linha[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida(txtGameName.Text, txtPassword.Text);
        }

        private void btnEnterGame_Click(object sender, EventArgs e)
        {
            string idPartida = listGames.SelectedItem.ToString();
            string[] lista = idPartida.Split(',');
            int id = Convert.ToInt32(lista[0]);
            Jogo.EntrarPartida(id, txtPlayerName.Text, txtPasswordGame.Text);
            Console.WriteLine("Branch testing");
        }

        private void lvlVersion_Click(object sender, EventArgs e)
        {
        }
    }
}
