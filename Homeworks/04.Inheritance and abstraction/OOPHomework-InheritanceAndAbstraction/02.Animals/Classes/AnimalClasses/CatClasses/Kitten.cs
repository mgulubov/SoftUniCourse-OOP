using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Classes.AnimalClasses.CatClasses
{
    class Kitten : Cat
    {
        public Kitten(String name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = 'f';
        }
    }
}
