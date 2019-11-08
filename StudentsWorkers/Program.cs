using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students("Ds", "Bs");
            s1.Grade = 9;
            Students s2 = new Students("Bs", "Lsa") { Grade = 8 };
            Students s3 = new Students("Cs", "Ws") { Grade = 7 };
            List<Students> listaStud = new List<Students>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);


            Workers w1 = new Workers("Ns", "Ps") { WeekSalary = 100, WorksHoursPerDay = 8 };
            Workers w2 = new Workers("Ms", "Ks") { WeekSalary = 70, WorksHoursPerDay = 8 };
            Workers w3 = new Workers("Gs", "Hj") { WeekSalary = 90, WorksHoursPerDay = 8 };
            List<Workers> listaWorkers = new List<Workers>();
            listaWorkers.Add(w1);
            listaWorkers.Add(w2);
            listaWorkers.Add(w3);

            var listWorkersOrder = listaWorkers.OrderBy(x => x.MoneyPerHour()).ToList();
            
            var listStudOrder = listaStud.OrderBy(x => x.Grade).ToList();
            
            for (int i = 0; i < listStudOrder.Count; i++)
            {
                listStudOrder[i].Print();
            }
            Console.WriteLine();
            for (int i = 0; i < listWorkersOrder.Count ; i++)
            {
                listWorkersOrder[i].Print();
            }
            Console.WriteLine();
            List<Human> listaHum = new List<Human>();
            listaHum.AddRange(listaStud);
            listaHum.AddRange(listaWorkers);
            
            var listHumOrder = listaHum.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            for (int i = 0; i < listHumOrder.Count(); i++)
            {
                listHumOrder[i].Print();
            }

            Console.ReadLine();
        }
    }
}
