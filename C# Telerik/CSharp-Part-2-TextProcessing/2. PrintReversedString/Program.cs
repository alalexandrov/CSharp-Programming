using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string input = Console.ReadLine();

            //Printing input reversed
            string reversed = string.Join("",input.Reverse());
            Console.WriteLine("The reversed string is: {0}", reversed);
        }
    }
}
