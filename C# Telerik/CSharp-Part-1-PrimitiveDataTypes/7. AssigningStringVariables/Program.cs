using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AssigningStringVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloString = "Hello";
            string WorldString = "World";

            object sentense = HelloString + " " + WorldString;

            string result = (string)sentense;
            Console.WriteLine(result);
        }
    }
}
