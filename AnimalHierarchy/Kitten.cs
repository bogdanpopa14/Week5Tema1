using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten:Cat,ISound
    {
        public override string Sex { get => base.Sex; protected set => base.Sex = "F"; }

        //public override string Name { get; protected set; }
        //public override int Age
        //{
        //    get;protected set;
        //}

        public Kitten(string name, int age,  string sex) : base(name, age, sex)
        {
            
        } 
        
    }
}
