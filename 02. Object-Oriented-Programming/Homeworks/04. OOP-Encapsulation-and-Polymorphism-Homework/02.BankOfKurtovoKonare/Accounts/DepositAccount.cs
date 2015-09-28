using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Customers;

namespace _02.BankOfKurtovoKonare.Accounts
{
    public class DepositAccount : Account, IAccount, IDepositable, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public decimal  CalculateInterest(double months)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }

       

        public void WithdrawMoney(decimal amount)
        {
            decimal withdraw = amount;
            if (withdraw > this.Balance)
            {
                Console.WriteLine(String.Format("Insufficient funds.Your balance is {0:N2} " +
                   "try witdrawing a smaller sum.", this.Balance));
            }
            else
            {
                this.Balance -= amount;
            }
        }
    }
}
