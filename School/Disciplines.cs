using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Disciplines
    {
        private int NumbersOfLectures { get; set; }
        private int NumberOfEx { get; set; }
        private string Name { get; set; }
        public Disciplines(string Name,int NrLec,int NrEx)
        {
            this.Name = Name;
            this.NumberOfEx = NrEx;
            this.NumbersOfLectures = NrLec;
        }
        public void Print()
        {
            Console.WriteLine($"\tDisciplina: {Name} are un nr de lect: {NumbersOfLectures} si un nr de ex: {NumberOfEx}");
        }
            
    }
}
