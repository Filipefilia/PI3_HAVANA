using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CantStopServer;

namespace PI3_Havana
{
    class Player
    {
        public int playerId { get; private set; }
        public string playerCollor { get; private set; }
        public string playerPassword { get; private set; }

        private Player (int inputPlayerId, string inputPlayerCollor, string inputPlayerPassword)
        {
            playerId = inputPlayerId;
            playerCollor = inputPlayerCollor;
            playerPassword = inputPlayerPassword;
        }

        public static List<Player> buildPlayerList (int inputGameId)
        {
            List<Player> players = new List<Player>();

            string response = Jogo.ListarJogadores(inputGameId);

            if (response != "")
            {
                string[] getPlayers = response.Replace("\r", "").Split('\n');

                for (int i  = 0; i < getPlayers.Length - 1; i++)
                {
                    string[] formatPlayers = getPlayers[i].Split(',');
                    Player currentPlayer = new Player(Convert.ToInt32(formatPlayers[0]), formatPlayers[1], formatPlayers[2]);
                    players.Add(currentPlayer);
                }
            }
            return players;
        }
    }
}
