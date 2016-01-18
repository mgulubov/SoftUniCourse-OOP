using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.TrainerClasses.TrainerTypes
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(String firstName, String lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override bool IsSenior()
        {
            return false;
        }
    }
}
