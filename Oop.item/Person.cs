using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal class Person
    {
        public string FristName { get; private set; }
        public string LastName { get; private set; }
        public void SetFullName(string fristName, string lastName)
        {

            if (string.IsNullOrWhiteSpace(fristName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Inveaild Name");


            FristName = fristName;
            LastName = lastName;

        }
        public DateTime BirthDate { get; private set; }
        public void SetBirthDate(DateTime birthDate)
        {
            if (birthDate < new DateTime(2000, 1, 1))
                throw new ArgumentException("Inveaild brithDay!!");
            BirthDate = birthDate;
        }
    }
}
