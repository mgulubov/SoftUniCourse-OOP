using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.StudentClasses.StudentTypes
{
    abstract class CurrentStudent : Student
    {
        private String _currentCourse;

        public CurrentStudent()
        {

        }

        public abstract bool IsOnsite();

        public String CurrentCourse
        {
            set
            {
                this._currentCourse = value;
            }
            get
            {
                return this._currentCourse;
            }
        }

        public override bool IsCurrent()
        {
            return true;
        }

        public override bool IsDropout()
        {
            return false;
        }

        public override bool IsGraduate()
        {
            return false;
        }
    }
}
