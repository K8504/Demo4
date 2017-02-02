using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();

            do
            {
                elevator.Floor = 1;
                Console.WriteLine("Choose floor, where you want to go. Choose from 1-5.");
                string feed = Console.ReadLine();
                elevator.Floor = int.Parse(feed);

                Console.WriteLine("Elevator is now in floor: " + elevator.Floor);
            } while (1 == 1);
        }
    }
}
