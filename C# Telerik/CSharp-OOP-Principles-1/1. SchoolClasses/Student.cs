using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class Student : Human, ICommentable
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length == 6)
                {
                    try
                    {
                        int.Parse(value);
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("The faculty number must contain only digits !");
                    }

                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("The faculty number must contain 6 digits !");
                }
            }
        }

        public Student(string name, string facultyNumber)
            : base(name)
        {
            this.FacultyNumber = facultyNumber;
        }
        public Student() { }

        public string Comment { get; set; }
    }
}
