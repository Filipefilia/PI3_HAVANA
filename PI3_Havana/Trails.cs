using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3_Havana
{
    class Trails
    {
        public string referencePosition { get; private set; }
        public int positionX { get; private set; }
        public int positionY { get; private set; }
        public int holdClimber { get; set; }
        public bool isConquered { get; set; }

        public Trails (string inputReference, int inputX, int inputY)
        {
            this.referencePosition = inputReference;
            this.positionX = inputX;
            this.positionY = inputY;
            this.holdClimber = 0;
            this.isConquered = false;
        }
    }
}
