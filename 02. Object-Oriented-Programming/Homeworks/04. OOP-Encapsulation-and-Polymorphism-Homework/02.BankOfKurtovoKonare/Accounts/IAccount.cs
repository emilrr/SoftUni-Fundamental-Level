using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Customers;

namespace _02.BankOfKurtovoKonare.Accounts
{
    public interface IAccount
    {
        ICustomer Customer { get; set; }
        decimal Balance { get; }
        decimal Interest { get; }
        decimal CalculateInterest(double months);
    }
}
