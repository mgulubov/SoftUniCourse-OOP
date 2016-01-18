using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Classes.AnimalClasses.CatClasses
{
    class Tomcat : Cat
    {
        public Tomcat(String name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = 'm';
        }
    }
}
