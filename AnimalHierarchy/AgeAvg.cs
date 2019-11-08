using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    static class AgeAvg
    {
        public static void Print(Animal[] s )
        {
            double agesum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                agesum += s[i].Age;
            }
            Console.WriteLine($"Media varstei celor {s.Length} animale este: {agesum / s.Length}");

        }
    }
}
