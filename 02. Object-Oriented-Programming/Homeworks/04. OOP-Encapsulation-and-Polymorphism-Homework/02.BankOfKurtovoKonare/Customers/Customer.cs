using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare.Customers
{
    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
             set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1)
                {
                    throw new ArgumentException("Customer's name can not be less than 1 charachter.");
                }
                this.name = value;
            }
        }

        
    }
}
