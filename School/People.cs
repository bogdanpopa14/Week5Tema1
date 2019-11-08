using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal abstract class People
    {
        public  abstract string LastName { get; protected set; }
        public abstract string FirstName { get; protected set; }
        protected People(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
