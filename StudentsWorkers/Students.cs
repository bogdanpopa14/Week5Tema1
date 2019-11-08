using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    public class Students : Human
    {
        public override string LastName { get;   protected set; }
        public override string FirstName { get; protected set; }
        public Students(string firstName, string lastName) : base(firstName, lastName) { }
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //}
        public int Grade { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student:  {FirstName} {LastName}, Grade: {Grade}");
        }

        
    }
}
