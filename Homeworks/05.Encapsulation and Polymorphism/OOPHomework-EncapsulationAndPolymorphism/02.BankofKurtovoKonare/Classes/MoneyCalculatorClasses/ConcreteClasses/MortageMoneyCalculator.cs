using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.AbstractClasses;

namespace _02.BankofKurtovoKonare.Classes.MoneyCalculatorClasses.ConcreteClasses
{
    class MortageMoneyCalculator : MoneyCalculator
    {
        public static readonly MoneyCalculator MONEY_CALCULATOR = new MortageMoneyCalculator();

        private MortageMoneyCalculator()
        {
            //private
        }

        public override decimal CalcInterest(DateTime openDate, int months, decimal interestRate,
            decimal balance, CustomerType type)
        {
            base.GetValidator().ValidateMonths(months, "Months can't be <= 0");

            switch (type)
            {
                case CustomerType.Company:
                    return CalcInterestForCompany(openDate, months, interestRate, balance, type);
                case CustomerType.Individual:
                    return CalcInterestForIndividual(openDate, months, interestRate, balance, type);
                default:
                    throw new ArgumentException("Something went terribly wrong with the type");
            }
        }

        private decimal CalcInterestForCompany(DateTime openDate, int months, decimal interestRate,
            decimal balance, CustomerType type)
        {
            decimal interest = balance * (1 + interestRate * months);

            if (months - 12 > 0)
            {
                
                return interest;
            }
            else
            {
                return interest / 2m;
            }
        }

        private decimal CalcInterestForIndividual(DateTime openDate, int months, decimal interestRate,
            decimal balance, CustomerType type)
        {
            if (months - 6 > 0)
            {
                return 0m;
            }

            decimal interest = balance * (1 + interestRate * months);
            return interest;
        }
    }
}
