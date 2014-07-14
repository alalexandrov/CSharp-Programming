using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanClasses
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException("Invalid grade! Value must be between 2 and 6.");
                }
            }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nGrade: {2}",
                this.FirstName, this.LastName, this.Grade);
        }
    }
}
