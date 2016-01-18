using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Interfaces;
using _02.BankofKurtovoKonare.Classes.CustomerClasses.AbstractClasses;

namespace _02.BankofKurtovoKonare.Classes.CustomerClasses.ConcreteClasses
{
    class CompanyCustomer : AbstractCustomer
    {
        public CompanyCustomer()
            : base(CustomerType.Company)
        {

        }
    }
}
