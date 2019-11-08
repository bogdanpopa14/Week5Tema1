using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitten k1 = new Kitten("Pis", 2, "A");
            Dog d1 = new Dog("Cut", 3, "M");
            Dog d2 = new Dog("Bsa", 5, "F");
            Dog[] caini = new Dog[] { d1,d2};
            AgeAvg.Print(caini);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(k1.Sex);
            Console.ReadLine();
        }
    }
}
