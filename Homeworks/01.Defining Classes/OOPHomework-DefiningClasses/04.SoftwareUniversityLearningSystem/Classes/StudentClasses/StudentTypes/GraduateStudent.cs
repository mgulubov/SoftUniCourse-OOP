using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.StudentClasses.StudentTypes
{
    class GraduateStudent : Student
    {
        public GraduateStudent(String firstName, String lastName, int age, int number, double avgGrade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = number;
            this.AvgGrade = avgGrade;
        }

        public override bool IsCurrent()
        {
            return false;
        }

        public override bool IsDropout()
        {
            return false;
        }

        public override bool IsGraduate()
        {
            return true;
        }
    }
}
