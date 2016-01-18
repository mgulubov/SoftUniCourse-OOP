using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Classes.AnimalClasses
{
    class Frog : Animal
    {
        public Frog(String name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ProduceSound()
        {
            return "Grubitt";
        }
    }
}
