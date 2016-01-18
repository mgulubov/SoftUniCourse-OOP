using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.SquareRoot.Classes;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String input = Console.ReadLine();

            int num;
            try
            {
                num = int.Parse(input);
                try
                {
                    Console.WriteLine(W0LfyMathematics.GetSquareRootOf(num));
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid Number");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
