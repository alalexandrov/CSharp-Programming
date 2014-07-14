using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _9.PrintFirst100MembersOfFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger fibonacci = a + b;
            Console.WriteLine("1. " + a);
            Console.WriteLine("2. " + b);

            for (int i = 0; i < 98; i++)
            {
                Console.WriteLine((i + 3) + ". " + fibonacci);
                a = b;
                b = fibonacci;
                fibonacci = a + b;
            }
        }
    }
}
