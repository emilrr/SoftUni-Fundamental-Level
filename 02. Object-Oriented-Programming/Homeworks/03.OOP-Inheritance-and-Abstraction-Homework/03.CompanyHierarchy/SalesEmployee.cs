using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class SalesEmployee:Employee, ISalesEmployee
    {
        private IList<Sale> sales;
        public SalesEmployee(string firstName, string lastName, string id, decimal salary, Department department, IList<Sale> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }
        
        public IList<Sale> Sales
        {
            get { return this.sales; }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("Sales employee must holds a set of sales.");
                }
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("{0}: {1} Sales",
                this.GetType().Name, base.ToString());

            int counter = 1;
            foreach (var sale in this.Sales)
            {
                result += "\n\n" + counter + "." + sale.ToString();

                counter++;
            }
            return result;
        }
    }
}
