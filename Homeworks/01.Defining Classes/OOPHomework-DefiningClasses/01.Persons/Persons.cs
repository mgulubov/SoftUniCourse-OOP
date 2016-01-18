using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Persons.Classes;

namespace _01.Persons
{
    class Persons
    {
        private static Person _person;
        private static readonly String NAME = "Evlogi";
        private static readonly int AGE = 27;
        private static readonly String VALID_EMAIL = "e.vlogi@gmail.com";
        private static readonly String INVALID_EMAIL = "Evlogi nqma mail";

        static void Main(string[] args)
        {
            //Check Constructor with full info
            _person = new Person(NAME, AGE, VALID_EMAIL);
            Console.WriteLine("TEST 1\n" + _person.ToString());

            //Check Constructor with name and age only
            _person = new Person(NAME, AGE);
            Console.WriteLine("TEST 2\n" + _person.ToString());

            //Try Invalid Name
            //EMPTY
            try
            {
                _person.Name = "";
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 3A\n" + ae.Message);
            }

            //EMPTY 2
            try
            {
                _person.Name = " ";
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 3B\n" + ae.Message);
            }

            //NULL
            try
            {
                _person.Name = null;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 3C\n" + ae.Message);
            }

            //Try Invalid Age
            //-1
            try
            {
                _person.Age = -1;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 4A\n" + ae.Message);
            }

            //0
            try
            {
                _person.Age = 0;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 4B\n" + ae.Message);
            }

            //101
            try
            {
                _person.Age = 101;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 4C\n" + ae.Message);
            }

            //Try Invalid Email
            //Empty
            try
            {
                _person.Email = "";
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 5A\n" + ae.Message);
            }

            //EMPTY 2
            try
            {
                _person.Email = " ";
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 5B\n" + ae.Message);
            }

            //Invalid format
            try
            {
                _person.Email = INVALID_EMAIL;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 5C\n" + ae.Message);
            }
        }
    }
}
