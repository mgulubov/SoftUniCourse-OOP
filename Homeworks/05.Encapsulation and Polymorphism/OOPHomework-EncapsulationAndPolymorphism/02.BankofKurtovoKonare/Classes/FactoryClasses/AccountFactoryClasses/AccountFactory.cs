using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.AccountClasses.ConcreteClasses;

namespace _02.BankofKurtovoKonare.Classes.FactoryClasses.AccountFactoryClasses
{
    class AccountFactory
    {
        public static readonly AccountFactory ACCOUNT_FACTORY = new AccountFactory();

        private AccountFactory()
        {
            //private
        }

        public IAccount CreateAccount(AccountType type, ICustomer customer)
        {
            switch (type)
            {
                case AccountType.Deposit:
                    return new DepositAccount(customer);
                case AccountType.Loan:
                    return new LoanAccount(customer);
                case AccountType.Mortage:
                    return new MortgageAccount(customer);
                default:
                    throw new ArgumentException("Unsupported Account type");
            }
        }
    }
}
