using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student:People
    {
        internal int Id;
        public override string FirstName { get; protected set; }
        public override string LastName { get; protected set; }
        public Student(string firstName,string lastName) : base(firstName, lastName) { }

        public void Print()
        {
            Console.WriteLine($"\t{FirstName} {LastName}, ID:{Id}");
        }
    }
}
