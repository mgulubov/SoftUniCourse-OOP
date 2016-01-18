using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using _03.PCCatalog.Classes;

namespace _03.PCCatalog.Classes
{

    class Computer
    {
        private List<Component> _components;
        private String _name;
        private decimal _price;

        public Computer(String name)
            : this(name, 0)
        {

        }

        public Computer(String name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this._components = new List<Component>();
        }

        public String Name
        {
            set
            {
                CheckIfValid(value, "Name can't be Null or Empty");
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
                CheckIfValid(value, "Price can't be < 0");
                this._price = value;
            }
            get
            {
                return this._price;
            }
        }

        public void AddComponent(String name, decimal price)
        {
            this.AddComponent(name, price, "Not available");
        }

        public void AddComponent(String name, decimal price, String details)
        {
            this._components.Add(new Component(name, price, details));
        }

        public override string ToString()
        {
            IOrderedEnumerable<Component> sortedList = SortComponentsByPrice();

            return String.Format("Computer Name: {0}\n\n" +
                                "{1}" +
                                "\nTotal Price: {2}\n", this.Name, String.Join("\n", sortedList),
                                this.GetTotalComponentsPrice());
        }

        private IOrderedEnumerable<Component> SortComponentsByPrice()
        {
            IOrderedEnumerable<Component> sortedComps = from comp in this._components
                                              orderby comp.Price descending
                                              select comp;

            return sortedComps;
            
        }

        public decimal GetTotalComponentsPrice()
        {
            decimal totalPrice = 0m;
            foreach (Component comp in this._components)
            {
                totalPrice += comp.Price;
            }

            return totalPrice;
        }

        public int GetComponentCount()
        {
            return this._components.Count;
        }

        private void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentException(message);
            }

            value = Regex.Replace(value, @"\s{2,}", "");
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
