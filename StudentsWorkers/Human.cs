using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    public abstract class Human
    {
        public abstract string LastName { get; protected set; }
        public abstract string FirstName { get; protected set; }

        public  Human(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
