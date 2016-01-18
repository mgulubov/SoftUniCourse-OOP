using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.FactoryClasses.CustomerFactoryClasses;

namespace _02.BankofKurtovoKonare
{
    class BankofKurtovoKonare
    {
        private static CustomerFactory _clientFactory = CustomerFactory.CUSTOMER_FACTORY;

        static void Main(string[] args)
        {
            List<ICustomer> clients = new List<ICustomer>();

            clients.Add(_clientFactory.CreateCustomer(CustomerType.Individual));
            clients.Add(_clientFactory.CreateCustomer(CustomerType.Company));

            clients[0].CreateAccount(AccountType.Deposit);
            clients[0].CreateAccount(AccountType.Loan);
            clients[0].CreateAccount(AccountType.Mortage);

            clients[1].CreateAccount(AccountType.Deposit);
            clients[1].CreateAccount(AccountType.Loan);
            clients[1].CreateAccount(AccountType.Mortage);

            List<IAccount> depositListIndividual = clients[0].GetAccountsOfType(AccountType.Deposit);
            List<IAccount> loanListIndividual = clients[0].GetAccountsOfType(AccountType.Loan);
            List<IAccount> mortageListIndividual = clients[0].GetAccountsOfType(AccountType.Mortage);

            List<IAccount> depositListCompany = clients[1].GetAccountsOfType(AccountType.Deposit);
            List<IAccount> loanListCompany = clients[1].GetAccountsOfType(AccountType.Loan);
            List<IAccount> mortageListCompany = clients[1].GetAccountsOfType(AccountType.Mortage);

            depositListIndividual[0].Deposit(200);
            loanListIndividual[0].Deposit(200);
            mortageListIndividual[0].Deposit(200);
            Console.WriteLine("{0}\n{1}\n{2}\n", depositListIndividual[0].GetBalance(),
                loanListIndividual[0].GetBalance(), mortageListIndividual[0].GetBalance());

            try
            {
                depositListIndividual[0].Withdraw(100);
                loanListIndividual[0].Withdraw(100);
                mortageListIndividual[0].Withdraw(100);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.WriteLine("{0}\n{1}\n{2}\n", depositListIndividual[0].GetBalance(),
                loanListIndividual[0].GetBalance(), mortageListIndividual[0].GetBalance());

            depositListCompany[0].Deposit(200);
            loanListCompany[0].Deposit(200);
            mortageListCompany[0].Deposit(200);
            Console.WriteLine("{0}\n{1}\n{2}\n", depositListCompany[0].GetBalance(),
                loanListCompany[0].GetBalance(), mortageListCompany[0].GetBalance());

            try
            {
                depositListCompany[0].Withdraw(100);
                loanListCompany[0].Withdraw(100);
                mortageListCompany[0].Withdraw(100);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.WriteLine("{0}\n{1}\n{2}\n", depositListCompany[0].GetBalance(),
                loanListCompany[0].GetBalance(), mortageListCompany[0].GetBalance());

            Console.WriteLine("{0}\n{1}\n{2}\n",
                depositListIndividual[0].CalcInterest(10),
                loanListIndividual[0].CalcInterest(13),
                mortageListIndividual[0].CalcInterest(13));
        }
    }
}
