using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.TrainerClasses.TrainerTypes
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(String firstName, String lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public void DeleteCourse(String course)
        {
            Console.WriteLine("A course has been deleted: {0}", course);
        }

        public override bool IsSenior()
        {
            return true;
        }
    }
}
