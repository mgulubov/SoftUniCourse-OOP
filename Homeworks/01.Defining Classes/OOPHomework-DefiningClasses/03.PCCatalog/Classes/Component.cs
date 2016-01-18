using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.PCCatalog.Classes
{
    class Component
    {
        private String _name;
        private decimal _price;
        private String _details;

        public Component(String name, decimal price)
            : this(name, price, "Not available")
        {

        }

        public Component(String name, decimal price, String details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public String Name
        {
            set
            {
                CheckIfValid(value, "Name can't be null or empty");
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }

        public decimal Price
        {
            set
            {
                CheckIfValid(value, "price can't be < 0");
                this._price = value;
            }
            get
            {
                return this._price;
            }
        }

        public String Details
        {
            set
            {
                CheckIfValid(value, "Details can't be null or empty");
                this._details = value;
            }
            get
            {
                return this._details;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                                "Details: {1}\n" +
                                "Price: {2}\n",
                                this.Name,
                                this.Details,
                                this.Price);
        }

        private void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentException(message);
            }

            value = Regex.Replace(value, @"\s{2,}", " ");
            if (value == "" || value == " ")
            {
                throw new ArgumentException(message);
            }
        }

        private void CheckIfValid(decimal dees, String message)
        {
            if (dees < 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
