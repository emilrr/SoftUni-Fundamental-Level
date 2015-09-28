using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare.Accounts
{
    public interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
