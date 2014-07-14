using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalClasses
{
    public enum Sex
    {
        Male,
        Female
    }
    class Animal : ISound
    {
        private string name;
        private int age;
        public Sex Sex { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && (value.Length > 1 && value.Length < 30))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " name!");
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " age !");
                }
            }
        }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.age = age;
            this.Sex = sex;
        }
        public Animal() { }

        public virtual void ProduceSound()
        {
            Console.WriteLine("I'am " + this.GetType().Name);
        }

        public override string ToString()
        {
            return string.Format("I'am " + this.GetType().Name +
                "\nMy name is: {0}\nI'am {1} years old\nMy sex is: {2}",
                this.Name, this.Age, this.Sex);
        }
    }
}
