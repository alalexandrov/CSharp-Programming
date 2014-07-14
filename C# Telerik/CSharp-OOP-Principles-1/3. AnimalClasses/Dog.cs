using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalClasses
{
    class Dog : Animal
    {
        public Dog(string name, int age, Sex sex) : base(name, age, sex) { }
        public override void ProduceSound()
        {
            Console.WriteLine("Bauuuu !!!");
        }
    }
}
