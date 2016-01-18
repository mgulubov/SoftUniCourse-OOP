using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.FactoryClasses.AccountFactoryClasses;
using _02.BankofKurtovoKonare.Classes.ValidationClasses;

namespace _02.BankofKurtovoKonare.Classes.CustomerClasses.AbstractClasses
{
    class AbstractCustomer : ICustomer
    {
        public readonly List<IAccount> _accountList;
        public readonly CustomerType _customerType;
        protected readonly IValidator _validator;
        private readonly AccountFactory _accountFactory;

        public AbstractCustomer(CustomerType customerType)
        {
            this._accountList = new List<IAccount>();
            this._customerType = customerType;
            this._validator = Validation.VALIDATOR;
            this._accountFactory = AccountFactory.ACCOUNT_FACTORY;
        }

        public void CreateAccount(AccountType accountType)
        {
            IAccount account = this._accountFactory.CreateAccount(accountType, this);
            this._accountList.Add(account);
        }

        public List<IAccount> GetAccountsOfType(AccountType type)
        {
            switch (type)
            {
                case AccountType.Deposit:
                    return this.GetAllAccounts(type);
                case AccountType.Loan:
                    return this.GetAllAccounts(type);
                case AccountType.Mortage:
                    return this.GetAllAccounts(type);
                default:
                    return this._accountList;
            }
        }

        public CustomerType GetCustomerType()
        {
            return this._customerType;
        }

        private List<IAccount> GetAllAccounts(AccountType type)
        {
            List<IAccount> result = new List<IAccount>();

            foreach (IAccount acc in this._accountList)
            {
                if (acc.GetAccountType() == type)
                {
                    result.Add(acc);
                }
            }

            return result;
        }
    }
}
