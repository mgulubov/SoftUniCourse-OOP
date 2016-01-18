using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankofKurtovoKonare.Interfaces
{
    enum AccountType
    {
        Loan,
        Mortage,
        Deposit
    };

    interface IAccount
    {
        decimal GetBalance();
        decimal CalcInterest(int monthsAhead);
        decimal Deposit(decimal amount);
        decimal Withdraw(decimal amount);
        decimal InterestRate { set; get; }
        DateTime GetOpenDate();
        ICustomer Customer { set; get; }
        AccountType GetAccountType();
    }
}
