using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankofKurtovoKonare.Interfaces
{
    enum CustomerType
    {
        Individual,
        Company
    }

    interface ICustomer
    {
        void CreateAccount(AccountType accountType);
        List<IAccount> GetAccountsOfType(AccountType type);
        CustomerType GetCustomerType();
    }
}
