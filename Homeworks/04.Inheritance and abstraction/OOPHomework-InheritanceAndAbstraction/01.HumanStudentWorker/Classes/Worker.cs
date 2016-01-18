using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker.Classes
{
    class Worker : Human
    {
        private decimal _weekSalary;
        private double _workHoursPerDay;
 
        public Worker(String firstName, String lastName)
            : this(firstName, lastName, 0m, 0d)
        {

        }

        public Worker(String firstName, String lastName, decimal weekSalary, double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            set
            {
                CheckIfValid(value, "Week Salary can't be < 0");
                this._weekSalary = value;
            }
            get
            {
                return this._weekSalary;
            }
        }

        public double WorkHoursPerDay
        {
            set
            {
                CheckIfValid(value, "Work Hours Per Day can't be < 0, or > 24");
                this._workHoursPerDay = value;
            }
            get
            {
                return this._workHoursPerDay;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal salaryPerDay = this.WeekSalary / 5;
            decimal salaryPerHour = salaryPerDay / (decimal)this.WorkHoursPerDay;

            return salaryPerHour;
        }

        private void CheckIfValid(decimal value, String message)
        {
            if (value < 0)
            {
                throw new ArgumentException(message);
            }
        }

        private void CheckIfValid(double value, String message)
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
