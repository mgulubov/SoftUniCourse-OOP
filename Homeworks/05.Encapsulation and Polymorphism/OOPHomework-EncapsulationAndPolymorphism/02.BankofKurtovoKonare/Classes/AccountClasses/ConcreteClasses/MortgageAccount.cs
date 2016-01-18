using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.AccountClasses.AbstractClasses;

namespace _02.BankofKurtovoKonare.Classes.AccountClasses.ConcreteClasses
{
    class MortgageAccount : AbstractAccount
    {
        public MortgageAccount(ICustomer customer)
            : base(customer, AccountType.Mortage)
        {

        }

        public override decimal Withdraw(decimal amount)
        {
            Console.WriteLine("Cannot withdraw from Mortgage account");
            return this.GetBalance();
        }
    }
}
