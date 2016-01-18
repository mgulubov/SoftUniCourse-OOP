using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot.Classes
{
    static class W0LfyMathematics
    {
        public static double GetSquareRootOf(int number)
        {
            CheckIfValid(number);
            return Math.Sqrt(number);
        }

        private static void CheckIfValid(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number can't be < 0");
            }
        }
    }
}
