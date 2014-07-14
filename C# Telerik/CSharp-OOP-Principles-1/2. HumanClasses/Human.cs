using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanClasses
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value != null && value.Length > 1 && value.Length < 20)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " first name!");
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value != null && value.Length > 1 && value.Length < 20)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " last name!");
                }
            }
        }

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
