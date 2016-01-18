using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods.Classes
{
    class Student
    {
        public int Grade { set; get; }
        private String Name { set; get; }

        public Student(String name, int grade)
        {
            Grade = grade;
            Name = name;
        }
    }
}
