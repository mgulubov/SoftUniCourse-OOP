using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankofKurtovoKonare.Interfaces
{
    interface IValidator
    {
        void ValidateMonths(int months, String message);
        void ValidateCustomer(ICustomer customer, String message);
        void ValidateInterestRate(decimal rate, String message);
        void ValidateDepositAmount(decimal amount, String message);
        void ValidateWithdrawAmount(decimal balance, decimal amount, String message);
    }
}
