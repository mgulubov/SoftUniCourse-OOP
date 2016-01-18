using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.InterestCalculator.Classes;

namespace _02.InterestCalculator
{
    class Program
    {
        public delegate decimal CalcInterest(decimal money, float interest, int years);

        static void Main(string[] args)
        {
            InterestCalculatorClass inOne = new InterestCalculatorClass(500, 5.6f, 10, new CalcInterest(GetCompoundInterest));
            Console.WriteLine(inOne.CalculaateInterest());

            InterestCalculatorClass inTwo = new InterestCalculatorClass(2500, 7.2f, 15, new CalcInterest(GetSimpleInterest));
            Console.WriteLine(inTwo.CalculaateInterest());
        }

        public static decimal GetSimpleInterest(decimal sum, float interest, int years)
        {
            return (sum * (1 + (decimal)(interest / 100) * years));
        }

        public static decimal GetCompoundInterest(decimal sum, float interest, int years)
        {
            decimal result = sum * ((decimal)(Math.Pow(1 + ((interest / 100) / 12), (12 * years))));

            return decimal.Parse(result.ToString("#.####"));
        }
    }
}
