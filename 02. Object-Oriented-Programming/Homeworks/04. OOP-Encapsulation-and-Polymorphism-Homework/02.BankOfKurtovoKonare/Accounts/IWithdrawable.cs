using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare.Accounts
{
    interface IWithdrawable : IAccount
    {
        void WithdrawMoney(decimal amount);
    }
}
