using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class Human
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && (value.Length > 1 && value.Length < 50))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " name !");
                }
            }
        }

        public Human(string name)
        {
            this.Name = name;
        }

        public Human() { }
    }
}
