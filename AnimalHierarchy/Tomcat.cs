using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age, string sex) : base(name, age, sex)
        {
            this.Sex = "M";
        }
    }
}
