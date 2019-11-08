using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teachers:People
    {
        public override  string LastName { get; protected set; }
        public override string FirstName { get; protected set; }
        public Teachers(string lastName,string firstName):base (lastName,firstName)
        {

        }
        private List<Disciplines> listaDisciplines = new List<Disciplines>();
        public void AddDisciplines(Disciplines d)
        {
            listaDisciplines.Add(d);
        }
        public void Print()
        {
            Console.WriteLine($"\tProf: {FirstName} {LastName} preda:");
            for (int i = 0; i < listaDisciplines.Count; i++)
            {
                listaDisciplines[i].Print();
            }
        }
    }
}
