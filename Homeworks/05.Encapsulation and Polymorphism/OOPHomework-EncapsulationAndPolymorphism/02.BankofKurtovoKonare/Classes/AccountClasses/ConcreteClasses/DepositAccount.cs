using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.AccountClasses.AbstractClasses;
using _02.BankofKurtovoKonare.Classes.ValidationClasses;

namespace _02.BankofKurtovoKonare.Classes.AccountClasses.ConcreteClasses
{
    class DepositAccount : AbstractAccount
    {

        public DepositAccount(ICustomer customer)
            : base(customer, AccountType.Deposit)
        {

        }

        public override decimal Withdraw(decimal amount)
        {
            this._validator.ValidateWithdrawAmount(this.GetBalance(), amount, "Withdraw amount can't be > balance");
            this._balance = this.GetBalance() - amount;

            return this.GetBalance();
        }
    }
}
