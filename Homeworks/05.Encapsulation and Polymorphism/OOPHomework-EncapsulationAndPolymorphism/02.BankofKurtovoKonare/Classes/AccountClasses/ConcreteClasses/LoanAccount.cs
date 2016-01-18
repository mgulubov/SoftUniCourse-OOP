using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.AccountClasses.AbstractClasses;

namespace _02.BankofKurtovoKonare.Classes.AccountClasses.ConcreteClasses
{
    class LoanAccount : AbstractAccount
    {
        public LoanAccount(ICustomer customer)
            : base(customer, AccountType.Loan)
        {

        }

        public override decimal Withdraw(decimal amount)
        {
            Console.WriteLine("Cannot withdraw from Loan account");
            return this.GetBalance();
        }
    }
}
