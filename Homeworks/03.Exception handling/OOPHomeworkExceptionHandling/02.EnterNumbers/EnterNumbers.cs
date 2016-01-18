using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        private static List<int> _numbers = new List<int>(10);

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                _numbers.Add(GetNumberFromUser(i));
            }

            Console.WriteLine("{0}", String.Join(" ", _numbers));
        }

        private static int GetNumberFromUser(int index)
        {
            int prevNum;
            try
            {
                prevNum = _numbers[index - 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                prevNum = 1;
            }

            Console.Write("Please enter a number thats > {0}: ", prevNum);
            String userInput = Console.ReadLine();

            int userNum;
            try
            {
                userNum = int.Parse(userInput);
            }
            catch (Exception e)
            {
                if (e.GetType().ToString() != "System.OverflowException" &&
                    e.GetType().ToString() != "System.FormatException" &&
                    e.GetType().ToString() != "System.ArgumentNullException")
                {
                    throw;
                }

                Console.WriteLine("{0} is not a valid number. Number should be a valid integer > {1} && < 100",
                    userInput, prevNum);

                return GetNumberFromUser(index);
            }

            if (userNum <= prevNum || userNum >= 100)
            {
                Console.WriteLine("Invalid Number. Number should be > {0} && < 100", prevNum);
                return GetNumberFromUser(index);
            }

            return userNum;
        }
    }
}
