using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();

            do
            {
                amplifier.Volume = 1;
                Console.WriteLine("Choose amplifier's volume from 0-100");
                string feed = Console.ReadLine();
                amplifier.Volume = int.Parse(feed);

                Console.WriteLine("Amplifier's volume is now: " + amplifier.Volume);
            } while (1 == 1);
        }
    }
}
