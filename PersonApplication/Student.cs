using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }

        // Default constructor
        public Student()
        {
        }

        // Parametric constructor calls base class constructor with parameters
        public Student(string firstName, string lastName, string studentID)
            :base(firstName,lastName)
        {
            StudentID = studentID;
        }

        // Just one method what Student can do
        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

        // Override base class ToString()
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
