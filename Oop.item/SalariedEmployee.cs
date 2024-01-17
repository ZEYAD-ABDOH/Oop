using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal class SalariedEmployee : Employee
    {
        public decimal BasiSalary { get; set; }
        public decimal Teansportaoin { get; set; }
        public decimal Housing { get; set; }

        public override IEnumerable<Payltem> GetPayltems()
        {

            return new[] { new Payltem("BosicSalary", BasiSalary),
              new Payltem("Teansportaoin", Teansportaoin),
              new Payltem("Housing", Housing)
            };
        }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return BasiSalary + Teansportaoin + Housing;

        }
        public decimal GetSalary(int teansportaoin)
        {
            return GetSalary() - (BasiSalary - teansportaoin / 100);
        }
        public decimal GetSalary(int teansportaoin, int bonus)
        {
            return GetSalary(teansportaoin) + bonus;
        }
    }
}
