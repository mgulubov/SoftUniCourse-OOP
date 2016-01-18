using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.SoftwareUniversityLearningSystem.Classes
{
    abstract class Person
    {
        private String _firstName;
        private String _lastName;
        private int _age;

        public Person()
        {

        }

        public abstract bool IsStudent();

        public String FirstName
        {
            set
            {
                CheckIfValid(value, "FirstName can't be null or empty");
                this._firstName = value;
            }
            get
            {
                return this._firstName;
            }
        }

        public String LastName
        {
            set
            {
                CheckIfValid(value, "LastName can't be null or empty");
                this._lastName = value;
            }
            get
            {
                return this._lastName;
            }
        }

        public int Age
        {
            set
            {
                CheckIfValid(value, "Age can't be <= 0");
                this._age = value;
            }
            get
            {
                return this._age;
            }
        }

        public void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }

            value = value.Trim();
            value = Regex.Replace(value, @"\s{2,}", " ");
            if (value == "" || value == " ")
            {
                throw new ArgumentException(message);
            }
        }

        public void CheckIfValid(int value, String message)
        {
            if (value <= 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
