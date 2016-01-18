using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.HumanStudentWorker.Classes
{
    class Student : Human
    {
        private String _facultyNumber;

        public Student(String firstName, String lastName)
            : this(firstName, lastName, "NotProvided")
        {

        }

        public Student(String firstName, String lastName, String facultyNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        public String FacultyNumber
        {
            set
            {
                CheckIfValid(value, "Faculty Number Can Contain Only Numbers And Letters");
                this._facultyNumber = value;
            }
            get
            {
                return this._facultyNumber;
            }
        }

        private void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }

            value = Regex.Replace(value, @"\s{2,}", " ");
            if (!(Regex.IsMatch(value, @"([a-zA-Z0-9]+)"))) 
            {
                throw new ArgumentException(message);
            }
        }
    }
}
