using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Classes.AnimalClasses
{
    abstract class Cat : Animal
    {
        public Cat()
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
