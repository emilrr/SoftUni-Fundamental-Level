using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare.Customers
{
    class Individual : Customer, ICustomer
    {
        public Individual(string name)
            : base(name)
        {
        }
    }
}
