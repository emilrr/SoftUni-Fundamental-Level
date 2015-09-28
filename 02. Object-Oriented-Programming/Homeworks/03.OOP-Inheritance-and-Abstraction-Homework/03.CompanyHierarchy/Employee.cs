using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfasec;

namespace _03.CompanyHierarchy
{
    public abstract class Employee:Person, IEmployee
    {
        private decimal salary;

        protected Employee(string firstName, string lastName, string id, decimal salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public Department Department { get; set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("Salary", "Salary can not be negative");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("{0}, Salary: {1}, Department: {2}",
                base.ToString(), this.Salary, this.Department);

            return result;
        }
    }
}
