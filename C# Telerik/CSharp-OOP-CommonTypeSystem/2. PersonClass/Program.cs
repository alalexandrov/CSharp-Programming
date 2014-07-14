using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Alex = new Person("Alex", 32);
            Person Pesho = new Person("Pesho");

            Console.WriteLine(Alex + "\n");
            Console.WriteLine(Pesho);
        }
    }
}
