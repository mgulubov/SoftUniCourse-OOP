using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.ValidationClasses;

namespace _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.AbstractClasses
{
    abstract class MoneyCalculator : IMoneyCalculator
    {
        private readonly IValidator _validator;
        public MoneyCalculator()
        {
            this._validator = Validation.VALIDATOR;
        }

        public abstract decimal CalcInterest(DateTime openDate, int months, decimal interestRate, 
            decimal balance, CustomerType type);

        public IValidator GetValidator()
        {
            return this._validator;
        }
    }
}
