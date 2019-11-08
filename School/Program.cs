using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplines d1 = new Disciplines("Geo", 3, 5);
            Disciplines d2 = new Disciplines("Mate", 6, 7);
            Disciplines d3 = new Disciplines("Rom", 5, 3);
            Disciplines d4 = new Disciplines("Bio", 8, 9);
            Teachers t1 = new Teachers("Asd", "Mna");
            Teachers t2 = new Teachers("Lfs", "Gfr");
            t1.AddDisciplines(d1);
            t1.AddDisciplines(d2);
            t2.AddDisciplines(d3);
            t2.AddDisciplines(d3);
            Student s1 = new Student("Poi", "Mhj");
            Student s2 = new Student("Lkj", "Iuy");
            Student s3 = new Student("Wio", "Qop");
            Clasa c1 = new Clasa("12A");
            c1.AddProf(t1);
            c1.AddProf(t2);
            c1.AddStud(s1);
            c1.AddStud(s2);
            c1.AddStud(s3);
            c1.Print();
            Console.ReadLine();
            
        }
    }
}
