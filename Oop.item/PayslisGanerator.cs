using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal class PayslisGanerator
    {
        public PayslisGanerator(INotufuer notufuer)
        {
            _notufuer = notufuer;
        }
        private readonly INotufuer _notufuer;
      
        public void Ganerator(Employee employee)
        {
            var Payitem = employee.GetPayltems();
            var message = new StringBuilder();
            message.AppendLine($"Dear:{employee.FristName} {employee.LastName}");
            message.AppendLine($"Please Findbleci Your payle ");
            foreach (var Payitems in Payitem)
            {
                message.AppendLine($"{Payitems.Name} {Payitems.Value}");
                _notufuer.Notufuer(employee.Email, "Payslisp Ganerator !", message.ToString());

            }
        }

    }
}
