using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal class InterEmployee : Employee
    {
        public override IEnumerable<Payltem> GetPayltems()
        {

            return new[] { new Payltem("BosicSalary", GetSalary()) };
        }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return 2000;
        }
    }
}
