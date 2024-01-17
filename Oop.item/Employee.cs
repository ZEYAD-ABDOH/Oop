using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal abstract class Employee:Person
    {
        public string? Email { get; internal set; }

        public abstract decimal GetSalary();
        public abstract IEnumerable<Payltem> GetPayltems();
        //public decimal TaxPerchage { get; private set; }
        //public void SetTaxPerchage(decimal taxPerchage)
        //{
        //    TaxPerchage = taxPerchage;
        //}

    }
}
