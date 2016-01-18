using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.StudentClasses.StudentTypes
{
    class DropoutStudent : Student
    {
        private String _dropoutReason;

        public DropoutStudent(String firstName, String lastName, int age,
            int number, double avgGrade, String dropoutReason)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = number;
            this.AvgGrade = avgGrade;
            this.DropoutReason = dropoutReason;
        }

        public String DropoutReason
        {
            set
            {
                this._dropoutReason = value;
            }
            get
            {
                return this._dropoutReason;
            }
        }

        public override bool IsCurrent()
        {
            return false;
        }

        public override bool IsDropout()
        {
            return true;
        }

        public override bool IsGraduate()
        {
            return false;
        }
    }
}
