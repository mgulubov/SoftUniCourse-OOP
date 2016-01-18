using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator.Classes
{
    class InterestCalculatorClass
    {
        private decimal Money { set; get; }
        private float Interest { set; get; }
        private int Years { set; get; }
        private Delegate dele;

        public InterestCalculatorClass(decimal money, float interest, int years, Delegate del)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.dele = del;
        }

        public decimal CalculaateInterest()
        {
            return (decimal)this.dele.DynamicInvoke(this.Money, this.Interest, this.Years);
        }
    }
}
