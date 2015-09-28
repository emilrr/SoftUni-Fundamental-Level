using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    public  class Manager : Employee, IManager
    {
        private IList<Employee> employees;
        public Manager(string firstName, string lastName, string id, decimal salary, Department department, IList<Employee> employees)
            : base(firstName, lastName, id, salary, department)
        {
            this.Employees = employees;
        }

        public IList<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("Manager must hold a set of employees");
                }
                this.employees = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("{0}: {1} Employees",
                this.GetType().Name, base.ToString());

            int counter = 1;
            foreach (var empl in this.Employees)
            {
                result += "\n\n" + counter + "." + employees.GetType().Name +
                          " : " + empl;
                counter++;
            }
            return result;
        }
    }
}
