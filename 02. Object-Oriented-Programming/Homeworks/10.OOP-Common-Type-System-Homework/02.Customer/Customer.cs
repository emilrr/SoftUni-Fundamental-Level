
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Customer
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, long id, string permanentAddress,
            string mobilePhone, string email, IList<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustType = customerType;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long ID { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments { get; private set; }
        public CustomerType CustType { get; private set; }


        public override bool Equals(object obj)
        {
            var other = obj as Customer;

            if (object.Equals(other, null))
            {
                return false;
            }

            if (!object.Equals(this.ID, other.ID))
            {
                return false;
            }

            else if (!object.Equals(this.CustType, other.CustType))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.ID.GetHashCode() ^ this.CustType.GetHashCode();
        }

        public object Clone()
        {
            Customer newCustomer = this.MemberwiseClone() as Customer;
            if (newCustomer == null)
            {
                throw new ArgumentNullException("Object can't be casted to customer type!");
            }

            newCustomer.Payments = new List<Payment>(this.Payments.Count);
            foreach (var payment in this.Payments)
            {
                newCustomer.Payments.Add(payment.Clone() as Payment);
            }

            return newCustomer;
        }

        public int CompareTo(Customer other)
        {
            string thisFullName = string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            string otherFullName = string.Format("{0} {1} {2}", other.FirstName, other.MiddleName, other.LastName);

            if (thisFullName.CompareTo(otherFullName) != 0)
            {
                return thisFullName.CompareTo(otherFullName);
            }
            else
            {
                return this.ID.CompareTo(other.ID);
            }
        }

        public override string ToString()
        {
            var strCustomer = new StringBuilder();

            strCustomer.AppendLine(String.Format("Customer: {0} {1} {2}", this.FirstName, this.LastName, this.ID));
            strCustomer.AppendLine(String.Format("Contacts: mobile phone: {0}, e-mail: {1}", this.MobilePhone, this.Email));

            return strCustomer.ToString();
        }

        public static bool operator ==(Customer n1, Customer n2)
        {
            if (object.Equals(n1, null))
            {
                return false;
            }

            return n1.Equals(n2);
        }

        public static bool operator !=(Customer n1, Customer n2)
        {
            if (object.Equals(n1, null))
            {
                return false;
            }

            return !n1.Equals(n2);
        }
    }
}
