using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3_Havana
{
    class Session
    {
        public List<Game> currentList = new List<Game>();
        public Session()
        {
            currentList = Game.buildGameList();
        }
    }
}
