using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal
    {
        public virtual string Name { get; protected set; }
        public abstract int Age { get; protected set; }
        public virtual string Sex { get; protected set; }
        public  Animal(string name,int age,string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
