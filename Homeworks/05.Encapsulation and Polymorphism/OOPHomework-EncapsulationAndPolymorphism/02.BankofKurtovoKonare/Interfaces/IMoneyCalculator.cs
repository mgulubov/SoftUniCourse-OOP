using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankofKurtovoKonare.Interfaces
{
    interface IMoneyCalculator
    {
        decimal CalcInterest(DateTime openDate, int months, decimal interestRate, 
            decimal balance, CustomerType type);
    }
}
