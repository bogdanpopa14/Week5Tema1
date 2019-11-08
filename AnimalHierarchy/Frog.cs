using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog:Animal,ISound
    {
        public override string Name { get; protected set; }
        public override int Age { get; protected set; }
        public override string Sex { get; protected set; }
        public Frog(string name, int age, string sex) : base(name, age, sex) { }

        public void Sound()
        {
            Console.WriteLine($"Broasca: {Name} face: BBB");
        }
    }
}
