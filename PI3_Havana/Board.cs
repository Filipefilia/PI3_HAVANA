using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3_Havana
{
    class Board
    {
        public List<Trails> createBoard { get; private set; }
        public Board ()
        {
            this.createBoard = getBoard();
        }
        private List<Trails> getBoard()
        {
            List<Trails> trailPositions = new List<Trails>();

            //Trail Number 2
            trailPositions.Add(new Trails("2,1", 84, 302));
            trailPositions.Add(new Trails("2,2", 84, 254));

            //Trail Number 3
            trailPositions.Add(new Trails("3,1", 118, 348));
            trailPositions.Add(new Trails("3,2", 118, 310));
            trailPositions.Add(new Trails("3,3", 118, 272));
            trailPositions.Add(new Trails("3,4", 118, 234));

            //Trail Number 4
            trailPositions.Add(new Trails("4,1", 159, 388));
            trailPositions.Add(new Trails("4,2", 159, 353));
            trailPositions.Add(new Trails("4,3", 158, 317));
            trailPositions.Add(new Trails("4,4", 158, 272));
            trailPositions.Add(new Trails("4,5", 158, 234));
            trailPositions.Add(new Trails("4,6", 158, 196));

            //Trail Number 5
            trailPositions.Add(new Trails("5,1", 197, 429));
            trailPositions.Add(new Trails("5,2", 197, 391));
            trailPositions.Add(new Trails("5,3", 198, 353));
            trailPositions.Add(new Trails("5,4", 198, 317));
            trailPositions.Add(new Trails("5,5", 197, 277));
            trailPositions.Add(new Trails("5,6", 196, 233));
            trailPositions.Add(new Trails("5,7", 196, 194));
            trailPositions.Add(new Trails("5,8", 195, 149));

            //Trail Number 6
            trailPositions.Add(new Trails("6,1", 236, 463));
            trailPositions.Add(new Trails("6,2", 235, 417));
            trailPositions.Add(new Trails("6,3", 234, 377));
            trailPositions.Add(new Trails("6,4", 235, 341));
            trailPositions.Add(new Trails("6,5", 235, 303));
            trailPositions.Add(new Trails("6,6", 235, 265));
            trailPositions.Add(new Trails("6,7", 235, 227));
            trailPositions.Add(new Trails("6,8", 235, 180));
            trailPositions.Add(new Trails("6,9", 232, 143));
            trailPositions.Add(new Trails("6,10", 234, 103));

            //Trail Number 7
            trailPositions.Add(new Trails("7,1", 275, 497));
            trailPositions.Add(new Trails("7,2", 275, 458));
            trailPositions.Add(new Trails("7,3", 275, 422));
            trailPositions.Add(new Trails("7,4", 275, 383));
            trailPositions.Add(new Trails("7,5", 273, 339));
            trailPositions.Add(new Trails("7,6", 271, 297));
            trailPositions.Add(new Trails("7,7", 275, 259));
            trailPositions.Add(new Trails("7,8", 270, 223));
            trailPositions.Add(new Trails("7,9", 269, 182));
            trailPositions.Add(new Trails("7,10", 269, 139));
            trailPositions.Add(new Trails("7,11", 268, 101));
            trailPositions.Add(new Trails("7,12", 269, 60));

            //Trail Number 8
            trailPositions.Add(new Trails("8,1", 308, 459));
            trailPositions.Add(new Trails("8,2", 310, 418));
            trailPositions.Add(new Trails("8,3", 309, 381));
            trailPositions.Add(new Trails("8,4", 309, 344));
            trailPositions.Add(new Trails("8,5", 308, 301));
            trailPositions.Add(new Trails("8,6", 308, 260));
            trailPositions.Add(new Trails("8,7", 308, 222));
            trailPositions.Add(new Trails("8,8", 308, 175));
            trailPositions.Add(new Trails("8,9", 308, 137));
            trailPositions.Add(new Trails("8,10", 308, 99));

            //Trail Number 9
            trailPositions.Add(new Trails("9,1", 344, 425));
            trailPositions.Add(new Trails("9,2", 345, 388));
            trailPositions.Add(new Trails("9,3", 345, 346));
            trailPositions.Add(new Trails("9,4", 345, 305));
            trailPositions.Add(new Trails("9,5", 344, 269));
            trailPositions.Add(new Trails("9,6", 343, 227));
            trailPositions.Add(new Trails("9,7", 343, 187));
            trailPositions.Add(new Trails("9,8", 343, 144));

            //Trail Number 10
            trailPositions.Add(new Trails("10,1", 382, 383));
            trailPositions.Add(new Trails("10,2", 381, 339));
            trailPositions.Add(new Trails("10,3", 380, 303));
            trailPositions.Add(new Trails("10,4", 380, 258));
            trailPositions.Add(new Trails("10,5", 380, 220));
            trailPositions.Add(new Trails("10,6", 380, 180));

            //Trail Number 11
            trailPositions.Add(new Trails("11,1", 419, 342));
            trailPositions.Add(new Trails("11,2", 418, 308));
            trailPositions.Add(new Trails("11,3", 418, 270));
            trailPositions.Add(new Trails("11,4", 418, 232));

            //Trail Number 12
            trailPositions.Add(new Trails("12,1", 448, 313));
            trailPositions.Add(new Trails("12,2", 448, 266));

            return trailPositions;
        }
    }
}
