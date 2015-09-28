using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Customers;

namespace _02.BankOfKurtovoKonare.Accounts
{
    class MortgageAccount : Account, IAccount, IDepositable
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }
        public override decimal CalculateInterest(double months)
        {

            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return (base.CalculateInterest(12) / 2) + base.CalculateInterest(months - 12);
                }
            }
            if (this.Customer is Individual)
            {
                if (months >= 6)
                {
                    return base.CalculateInterest(months - 6);
                }
                else
                {
                    return this.Balance;
                }
            }
            return base.CalculateInterest(months);
        }
    }
}
