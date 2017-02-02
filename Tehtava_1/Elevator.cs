using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_1
{
    class Elevator
    {
        // Max Floor
        private readonly int maxFloor = 5;
        // Min Floor 
        private readonly int minFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor)
                {
                    floor = value;
                }
                else
                {
                    Console.WriteLine("There's no such a floor in this building. Choose another one.");
                }
            }
        }
    }
}
