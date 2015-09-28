using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Customers;

namespace _02.BankOfKurtovoKonare.Accounts
{
    public abstract class Account : IAccount, IDepositable
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interest;

        protected Account(ICustomer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public ICustomer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer", "Customer can not be null");
                }
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance", "Balance can not be a negative number");
                }
                this.balance = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest", "Interest can not be a negative number");
                }
                this.interest = value;
            }
        }

        decimal IAccount.CalculateInterest(double months)
        {
            throw new NotImplementedException();
        }

        public virtual void Deposit(decimal depositSum)
        {
            decimal deposit = depositSum;

            if (deposit < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit", "Deposit can not be a negative number");
            }

            this.Balance += deposit;
        }

        public virtual decimal CalculateInterest(double months)
        {
            double month = months;
            if (month < 0)
            {
                throw new ArgumentOutOfRangeException("Period", "Period can not be a negative number");
            }
            else
            {
                return this.Balance * (1 + ((this.Interest * (decimal)months) / 100));
            }
        }


    }
}
