using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;


namespace PI3_Havana
{
    class Game
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string date { get; private set; }
        public string status { get; private set;  }

        private Game (int inputId, string inputName, string inputDate, string inputStatus)
        {
            id = inputId;
            name = inputName;
            date = inputDate;
            status = inputStatus;
        }
        
        public static List<Game> buildGameList ()
        {
            //Response treatment
            string response = Jogo.ListarPartidas("T");
            List<Game> games = new List<Game>();
            response = response.Replace("\r", "");
            string[] line = response.Split('\n');
            for (int i = 0; i < line.Length - 1; i++)
            {
                string[] items = line[i].Split(',');
                Game createGame = new Game(Convert.ToInt16(items[0]), items[1], items[2], items[3]);
                games.Add(createGame);
            }
            return games;
        }
    }
}
