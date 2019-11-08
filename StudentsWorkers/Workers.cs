using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Workers:Human
    {
        public override string FirstName { get; protected set; }
        public override string LastName { get; protected set; }
        public Workers(string firstName, string lastName) : base(firstName, lastName) { }
        
        public double WeekSalary { get; set; }
        public double WorksHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorksHoursPerDay * 5);
        }

        public void Print()
        {
            Console.WriteLine($"Muncitor: {FirstName} {LastName}");
            Console.WriteLine($"Bani pe ora: {MoneyPerHour()}");
            Console.WriteLine();
        }
    }
}
