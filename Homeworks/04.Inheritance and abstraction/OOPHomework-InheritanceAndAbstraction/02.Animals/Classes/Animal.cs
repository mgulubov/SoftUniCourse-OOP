using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Interfaces;

namespace _02.Animals.Classes
{
    abstract class Animal : ISoundProducible
    {
        private String _name;
        private int _age;
        private char _gender;

        public Animal()
        {

        }

        public abstract String ProduceSound();

        public String Name
        {
            set
            {
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
                this._age = value;
            }
            get
            {
                return this._age;
            }
        }

        public char Gender
        {
            set
            {
                this._gender = value;
            }
            get
            {
                return this._gender;
            }
        }
    }
}
