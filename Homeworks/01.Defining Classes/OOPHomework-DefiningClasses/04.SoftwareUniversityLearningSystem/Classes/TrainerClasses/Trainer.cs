using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.TrainerClasses
{
    abstract class Trainer : Person
    {
        public Trainer()
        {

        }

        public abstract bool IsSenior();

        public override bool IsStudent()
        {
            return false;
        }

        public void CreateCourse(String course)
        {
            Console.WriteLine("A new course has been created: {0}", course);
        }
    }
}
