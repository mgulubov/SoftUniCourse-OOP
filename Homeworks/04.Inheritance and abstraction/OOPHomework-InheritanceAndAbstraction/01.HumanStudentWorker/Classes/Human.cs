using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.HumanStudentWorker.Classes
{
    abstract class Human
    {
        private String _firstName;
        private String _lastName;

        public Human()
        {

        }

        public String FirstName
        {
            set
            {
                CheckIfValid(value, "First Name can't be null or empty");
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
                CheckIfValid(value, "Last Name can't be null or empty");
                this._lastName = value;
            }
            get
            {
                return this._lastName;
            }
        }

        public String FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        private void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }

            value = Regex.Replace(value, @"\s{2,}", " ");
            if (value == "" || value == " ")
            {
                throw new ArgumentException(message);
            }
        }
    }
}
