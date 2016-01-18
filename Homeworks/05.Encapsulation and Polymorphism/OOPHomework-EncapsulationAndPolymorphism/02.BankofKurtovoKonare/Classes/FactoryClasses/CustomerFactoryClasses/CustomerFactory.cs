using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.CustomerClasses.ConcreteClasses;

namespace _02.BankofKurtovoKonare.Classes.FactoryClasses.CustomerFactoryClasses
{
    class CustomerFactory
    {
        public static readonly CustomerFactory CUSTOMER_FACTORY = new CustomerFactory();

        private CustomerFactory()
        {
            //private
        }

        public ICustomer CreateCustomer(CustomerType type)
        {
            switch (type)
            {
                case CustomerType.Company:
                    return new CompanyCustomer();
                case CustomerType.Individual:
                    return new IndividualCustomer();
                default:
                    throw new ArgumentException("Customer type not supported");
            }
        }
    }
}
