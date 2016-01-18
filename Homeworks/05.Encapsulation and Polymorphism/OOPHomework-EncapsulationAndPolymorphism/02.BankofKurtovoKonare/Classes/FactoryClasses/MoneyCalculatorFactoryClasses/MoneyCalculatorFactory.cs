using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.ConcreteClasses;

namespace _02.BankofKurtovoKonare.Classes.FactoryClasses.MoneyCalculatorFactoryClasses
{
    class MoneyCalculatorFactory
    {
        public static readonly MoneyCalculatorFactory MONEY_CALC_FACTORY = new MoneyCalculatorFactory();

        private MoneyCalculatorFactory()
        {
            //private
        }

        public IMoneyCalculator CreateCalculator(AccountType type)
        {
            switch (type)
            {
                case AccountType.Deposit:
                    return DepositMoneyCalculator.MONEY_CALCULATOR;
                case AccountType.Loan:
                    return LoanMoneyCalculator.MONEY_CALCULATOR;
                case AccountType.Mortage:
                    return MortageMoneyCalculator.MONEY_CALCULATOR;
                default:
                    throw new ArgumentException("Something went terribly wrong in the calc factory");
            }
        }
    }
}
