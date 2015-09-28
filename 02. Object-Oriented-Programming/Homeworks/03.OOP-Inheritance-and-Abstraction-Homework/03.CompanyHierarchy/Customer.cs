using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal sumAmount;

        public Customer(string firstName, string lastName, string id, decimal sumAmount) 
            : base(firstName, lastName, id)
        {
            this.SumAmount = sumAmount;
        }

        public decimal SumAmount
        {
            get { return this.sumAmount; }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("Sum can not be negative.");
                }
            }
        }
        public override string ToString()
        {
            string result = string.Format("{0}: {1} {2}, ID: {3}, Total amount of money: {4}",
                this.GetType().Name, this.FirstName, this.LastName, this.ID, this.SumAmount);

            return result;
        }
    }
}
