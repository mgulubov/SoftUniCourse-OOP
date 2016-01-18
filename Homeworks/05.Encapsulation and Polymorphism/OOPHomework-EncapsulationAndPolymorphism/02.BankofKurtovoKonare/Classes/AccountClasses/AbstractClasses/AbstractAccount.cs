using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.FactoryClasses.MoneyCalculatorFactoryClasses;
using _02.BankofKurtovoKonare.Classes.ValidationClasses;

namespace _02.BankofKurtovoKonare.Classes.AccountClasses.AbstractClasses
{
    abstract class AbstractAccount : IAccount
    {
        private readonly IMoneyCalculator _moneyCalculator;
        protected readonly IValidator _validator;
        protected decimal _balance;
        private decimal _interestRate;
        private ICustomer _customer;
        private readonly DateTime _openDate;
        private readonly AccountType _accountType;

        public AbstractAccount(ICustomer customer, AccountType accountType)
        {
            this._moneyCalculator = MoneyCalculatorFactory.MONEY_CALC_FACTORY.CreateCalculator(this.GetAccountType());
            this._validator = Validation.VALIDATOR;
            this._openDate = DateTime.Now;

            this.Customer = customer;

            this._accountType = accountType;

            this._balance = 0;
        }

        public abstract decimal Withdraw(decimal amount);

        public decimal GetBalance()
        {
            return this._balance;
        }

        public decimal CalcInterest(int monthsAhead)
        {
            this._validator.ValidateMonths(monthsAhead, "MOnths can't be <= 0");

            return this._moneyCalculator.CalcInterest(this.GetOpenDate(), monthsAhead, 
                this.InterestRate, this.GetBalance(), this.Customer.GetCustomerType());
        }

        public decimal InterestRate
        {
            set
            {
                this._validator.ValidateInterestRate(value, "Value can't be < 0");
                this._interestRate = value;
            }
            get
            {
                return this._interestRate;
            }
        }

        public decimal Deposit(decimal amount)
        {
            this._validator.ValidateDepositAmount(amount, "Deposit amount can't be <= 0");
            this._balance = this._balance + amount;

            return this.GetBalance();
        }

        public DateTime GetOpenDate()
        {
            return this._openDate;
        }

        public ICustomer Customer
        {
            set
            {
                this._validator.ValidateCustomer(value, "Customer can't be null");
                this._customer = value;
            }
            get
            {
                return this._customer;
            }
        }

        public AccountType GetAccountType()
        {
            return this._accountType;
        }

    }
}
