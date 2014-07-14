using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirstNameBeforeLastNameStudent
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nAge: {2}\n", this.FirstName, this.LastName, this.Age);
        }
    }
}
