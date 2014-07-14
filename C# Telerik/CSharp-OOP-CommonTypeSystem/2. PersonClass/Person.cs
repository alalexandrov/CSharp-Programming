using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PersonClass
{
    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            string PersonAge = this.Age.ToString();;
            if (this.Age == null)
            {
                PersonAge = "not specified";
            }

            return string.Format("Name: {0}\nAge: {1}", this.Name, PersonAge);
        }
    }
}
