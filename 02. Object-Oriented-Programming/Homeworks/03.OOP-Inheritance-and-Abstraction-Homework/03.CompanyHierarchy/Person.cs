using System;
using System.Text;
using System.Text.RegularExpressions;
using _03.CompanyHierarchy.Interfasec;

namespace _03.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private string id;

        protected Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName", "First name can not be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("LastName", "Last name can not be empty");
                }
                this.lastName = value;
            }
        }

        public string ID
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ID cannot be null");
                }
                this.id = value;
            }

        }

        public override string ToString()
        {
            string result = String.Format("Name: {0} {1}, ID: {2}",
                this.FirstName, this.LastName, this.ID);

            return result;
        }
    }
}
