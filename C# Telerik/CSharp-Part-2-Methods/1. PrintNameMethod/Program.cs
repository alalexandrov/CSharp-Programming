using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintNameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloName();
        }

        public static void HelloName()
        {
            Console.Write("What is your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}", input);
        }
    }
}
