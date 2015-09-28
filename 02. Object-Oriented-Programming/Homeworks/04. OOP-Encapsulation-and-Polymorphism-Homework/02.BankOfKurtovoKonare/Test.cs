using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Accounts;
using _02.BankOfKurtovoKonare.Customers;

namespace _02.BankOfKurtovoKonare
{
    class Test
    {
        private static void Main()
        {
            ICustomer georgi = new Individual("Georgi Terziev");
            ICustomer ldsCompany = new Company("LDS Ltd.");

            IAccount mortgageAccInd = new MortgageAccount(georgi, 1024m, 5.3m);
            IAccount mortgageAccComp = new MortgageAccount(ldsCompany, 1024m, 5.3m);
            IAccount loanAccInd = new LoanAccount(georgi, 1024m, 5.3m);
            IAccount loanAccComp = new LoanAccount(ldsCompany, 1024m, 5.3m);
            IAccount depositAccIndBig = new DepositAccount(georgi, 1024m, 5.3m);
            IAccount depositAccIndSmall = new DepositAccount(georgi, 999m, 5.3m);
            IAccount depositAccComp = new DepositAccount(ldsCompany, 11024m, 4.3m);

            List<IAccount> accounts = new List<IAccount>()
            {
                mortgageAccInd,
                mortgageAccComp,
                loanAccInd,
                loanAccComp,
                depositAccIndBig,
                depositAccIndSmall,
                depositAccComp
            };

            foreach (var acc in accounts)
            {
                Console.WriteLine(
                    "{5} {0,-15}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    acc.GetType().Name,
                    acc.CalculateInterest(2),
                    acc.CalculateInterest(3),
                    acc.CalculateInterest(10),
                    acc.CalculateInterest(13),
                    acc.Customer.GetType().Name);
            }
        }
    }
}
