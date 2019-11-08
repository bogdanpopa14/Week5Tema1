using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Clasa
    {
        private Random id = new Random();
        private List<Teachers> listaProf = new List<Teachers>();
        private List<Student> listaStu = new List<Student>();
        private string Nume { get; set; }
        public Clasa(string Name)
        {
           
          
            this.Nume = Name;
        }
        public void AddStud(Student s)
        {
             
            s.Id = id.Next();
               listaStu.Add(s);
        }
        public void AddProf(Teachers t)
        {
            listaProf.Add(t);
        }
        public void Print()
        {
            Console.WriteLine($"Clasa: {Nume}");
            Console.WriteLine("Predau urmatorii prof:");
            for (int i = 0; i < listaProf.Count; i++)
            {
                listaProf[i].Print();
            }
            Console.WriteLine("Contine urmatorii elevi:");
            for (int i = 0; i < listaStu.Count; i++)
            {
                listaStu[i].Print();
            }
        }

    }
}
