using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.AbstractClasses;

namespace _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.ConcreteClasses
{
    class DepositMoneyCalculator : MoneyCalculator
    {
        public static readonly MoneyCalculator MONEY_CALCULATOR = new DepositMoneyCalculator();

        private DepositMoneyCalculator()
        {
            //private
        }

        public override decimal CalcInterest(DateTime openDate, int months, decimal interestRate,
            decimal balance, CustomerType type)
        {
            base.GetValidator().ValidateMonths(months, "Months can't be <= 0");

            if (this.ClientIsEligableForInterest(balance))
            {
                decimal interest = balance * (1 + interestRate * months);
                return interest;
            }

            return 0m;
        }

        private bool ClientIsEligableForInterest(decimal balance)
        {
            return balance > 0 && balance < 1000;
        }
    }
}
