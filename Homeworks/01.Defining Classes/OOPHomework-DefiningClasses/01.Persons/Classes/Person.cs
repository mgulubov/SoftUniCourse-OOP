using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Persons.Classes
{
    class Person
    {
        private String _name;
        private int _age;
        private String _email;

        public Person(String name, int age)
            : this(name, age, null)
        {

        }

        public Person(String name, int age, String email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public String Name
        {
            set
            {
                CheckIfValid(value, "Name can't be NULL or Empty");
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }

        public int Age
        {
            set
            {
                CheckIfValid(value, "Age must be > 0 && <= 100");
                this._age = value;
            }
            get
            {
                return this._age;
            }
        }

        public String Email
        {
            set
            {
                CheckIfValidEmail(value, "Invalid Email Format");
                this._email = value;
            }
            get
            {
                return this._email;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                                "Age: {1}\n" +
                                "Email: {2}\n",
                                this.Name, this.Age,
                                this.Email == null ? "Not Provided" : this.Email);
        }

        private void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentException(message);
            }

            value = Regex.Replace(value, @"\s{2,}", " ");
            if (value == "" || value == " ")
            {
                throw new ArgumentException(message);
            }
        }

        private void CheckIfValid(int value, String message)
        {
            if (value <= 0 || value > 100)
            {
                throw new ArgumentException(message);
            }
        }

        private void CheckIfValidEmail(String email, String message)
        {
            if (email == null)
            {
                return;
            }

            String emailPatter = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))" + 
                @"|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (!(Regex.IsMatch(email, emailPatter, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
