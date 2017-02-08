using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApplication
{
    class Amplifier
    {
        // Max Volume
        private readonly int maxVolume = 100;
        // Min Volume
        private readonly int minVolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Value you set isn't in limited area. Choose another one.");
                }
            }
        }
    }
}
