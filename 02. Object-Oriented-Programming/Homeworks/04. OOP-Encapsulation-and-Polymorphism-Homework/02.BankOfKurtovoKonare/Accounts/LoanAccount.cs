using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Customers;

namespace _02.BankOfKurtovoKonare.Accounts
{
    class LoanAccount : Account, IAccount, IDepositable
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public override decimal CalculateInterest(double period)
        {
            if (this.Customer is Individual)
            {
                if (period > 3)
                {
                    base.CalculateInterest(period - 3);
                    Console.WriteLine("No interest is accrued for the first 3 months on Individuals Loan Accounts");
                }
                else if (period <= 3 && period > 0)
                {
                    Console.WriteLine("No interest is accrued for the first 3 months on Individuals Loan Accounts");
                }
                else if (period < 0)
                {
                    base.CalculateInterest(period);
                }
            }
            else if (this.Customer is Company)
            {
                if (period > 2)
                {
                    base.CalculateInterest(period - 2);
                    Console.WriteLine("No interest is accrued for the first 2 months on Companies Loan Accounts");
                }
                else if (period <= 2 && period > 0)
                {
                    Console.WriteLine("No interest is accrued for the first 2 months on Companies Loan Accounts");
                }
                else if (period < 0)
                {
                    base.CalculateInterest(period);
                }
            }
            return base.CalculateInterest(period);
        }
    }
}
