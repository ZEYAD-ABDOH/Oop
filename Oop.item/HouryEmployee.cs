using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal class HouryEmployee : Employee
    {
        public decimal HouryRute { get; set; }
        public decimal TotaHours { get; set; }

        public override IEnumerable<Payltem> GetPayltems()
        {

            return new[] { new Payltem("ToalHours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            return  HouryRute * TotaHours;
        }

    }
}
