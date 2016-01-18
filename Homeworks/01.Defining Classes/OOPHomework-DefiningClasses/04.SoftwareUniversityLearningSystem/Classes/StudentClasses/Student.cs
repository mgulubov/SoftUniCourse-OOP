using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.StudentClasses
{
    abstract class Student : Person
    {
        private int _studentNumber;
        private double _avgGrade;

        public Student()
        {

        }

        public abstract bool IsCurrent();
        public abstract bool IsDropout();
        public abstract bool IsGraduate();

        public override bool IsStudent()
        {
            return true;
        }

        public int StudentNumber
        {
            set
            {
                this._studentNumber = value;
            }
            get
            {
                return this._studentNumber;
            }
        }

        public double AvgGrade
        {
            set
            {
                this._avgGrade = value;
            }
            get
            {
                return this._avgGrade;
            }
        }
    }
}
