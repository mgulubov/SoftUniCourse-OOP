using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Classes;
using _02.Animals.Classes.AnimalClasses;
using _02.Animals.Classes.AnimalClasses.CatClasses;

namespace _02.Animals
{
    class Animals
    {
        private static Animal[] _animalsArr;

        static void Main(string[] args)
        {
            _animalsArr = new Animal[5];

            _animalsArr[0] = new Frog("Froggy", 3, 'm');
            _animalsArr[1] = new Dog("Kudgo", 10, 'm');
            _animalsArr[2] = new Kitten("Pussy", 3);
            _animalsArr[3] = new Tomcat("Kotaran", 4);
            _animalsArr[4] = new Dog("Big Bertha", 11, 'f');

            foreach (var a in _animalsArr.GroupBy(x => x.GetType().Name))
            {
                Console.WriteLine("Animal: {0}\nAvarage Age: {1}\n",
                    a.Key, a.Select(x => x.Age).Average());
            }
        }
    }
}
