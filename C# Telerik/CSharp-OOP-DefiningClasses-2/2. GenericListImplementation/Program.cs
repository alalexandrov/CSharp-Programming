using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GenericListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            GenericList<string> names = new GenericList<string>();
            names.Add("Alex");
            names.Add("Katq");
            names.Add("Mariq");
            names.Add("Gosho");
            names.Add("ZZZZ");

            names.InsertAt("Tosho", 0);
            names.InsertAt("Ivan", 4);

            names.RemoveAt(2);

            Console.WriteLine(names.Find("Mariq"));
            Console.WriteLine(names.ToString());

            Console.WriteLine(names.Max<string>());
            Console.WriteLine(names.Min<string>());

            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(10);
            numbers.Add(0);

            Console.WriteLine(numbers.Max<int>());
            Console.WriteLine(numbers.Min<int>());
        }
    }
}
