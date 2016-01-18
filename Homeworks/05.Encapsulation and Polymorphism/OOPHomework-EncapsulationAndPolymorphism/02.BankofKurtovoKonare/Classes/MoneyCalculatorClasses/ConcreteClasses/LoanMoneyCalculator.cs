using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.AbstractClasses;

namespace _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.ConcreteClasses
{
    class LoanMoneyCalculator : MoneyCalculator
    {
        public static readonly MoneyCalculator MONEY_CALCULATOR = new LoanMoneyCalculator();

        private LoanMoneyCalculator()
        {
            //private
        }

        public override decimal CalcInterest(DateTime openDate, int months, decimal interestRate, 
            decimal balance, CustomerType type)
        {
            base.GetValidator().ValidateMonths(months, "Months can't be <= 0");
            
            if (this.ClientIsEligableForInterest(type, months))
            {
                decimal interest = balance * (1 + interestRate * months);
                return interest;
            }

            return 0m;
        }

        private bool ClientIsEligableForInterest(CustomerType type, int months)
        {
            switch (type)
            {
                case CustomerType.Individual:
                    return months - 3 > 0;
                case CustomerType.Company:
                    return months - 2 > 0;
                default:
                    throw new ArgumentException("Something went terribly wrong with the months!");
            }
        }
    }
}
