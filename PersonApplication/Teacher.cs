using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // Default constructor
        public Teacher()
        {
        }

        // Parametric constructor calls base class constructor with parameters
        public Teacher(string firstName, string lastName, string room)
            :base(firstName,lastName)
        {
            Room = room;
        }

        // Just one method what Teacher can do
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        // Override base class ToString()-method
        public override string ToString()
        {
            // Kutsutaan yliluokan ( tässä tapauksessa Person) ToString()-metodia
            return base.ToString() + " " + Room;
        }
    }
}
