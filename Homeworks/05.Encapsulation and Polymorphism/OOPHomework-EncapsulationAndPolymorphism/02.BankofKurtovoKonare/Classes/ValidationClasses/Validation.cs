using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;

namespace _02.BankofKurtovoKonare.Classes.ValidationClasses
{
    class Validation : IValidator
    {
        public static readonly IValidator VALIDATOR = new Validation();

        private Validation()
        {
            //private
        }

        public void ValidateMonths(int months, String message)
        {
            if (months <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public void ValidateCustomer(ICustomer customer, String message)
        {
            if (customer == null)
            {
                throw new ArgumentException(message);
            }
        }

        public void ValidateInterestRate(decimal rate, String message)
        {
            if (rate < 0)
            {
                throw new ArgumentException(message);
            }
        }

        public void ValidateDepositAmount(decimal amount, String message)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public void ValidateWithdrawAmount(decimal balance, decimal amount, String message)
        {
            if (amount > balance)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
