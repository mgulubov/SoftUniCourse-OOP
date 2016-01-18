using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.CustomLINQExtensionMethods.LINQExtensions;
using _01.CustomLINQExtensionMethods.Classes;

namespace _01.CustomLINQExtensionMethods
{
    class Program
    {
        public static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> filteredNums = nums.WhereNot(x => x % 2 == 0).ToList();
            Console.WriteLine(String.Join(", ", filteredNums));

            List<Student> students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5),
            };
            Console.WriteLine(students.Max(x => x.Grade));
        }
    }
}
