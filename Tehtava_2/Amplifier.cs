using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_2
{
    class Amplifier
    {
        // Max Volume
        private readonly int maxVolume = 100;
        // Min Volume
        private readonly int minVolume = 0;

        private int amplifier;

        public int Amplifier
        {
            get
            {
                return amplifier;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume)
                {
                    Amplifier = value;
                }
                else
                {
                    Console.WriteLine("Value you set isn't in limited area. Choose another one.");
                }
            }
        }
            
    }
}
