using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class School
    {
        private StudentsClass[] classes;

        public StudentsClass[] Classes
        {
            get
            {
                return (StudentsClass[])this.classes.Clone();
            }
            set
            {
                if (value != null)
                {
                    this.classes = value;
                }
                else
                {
                    throw new ArgumentException("The value of classes can't be null !");
                }
            }
        }
    }
}
