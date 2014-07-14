using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanClasses
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value > 0)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentException("Invalid salary !");
                }
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value > 0)
                {
                    this.workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentException("Invalid work hours per day !");
                }
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return Math.Round(this.WeekSalary / (this.WorkHoursPerDay * 7), 2);
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nWeek salary: {2}\nWork hours/day: {3}",
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
