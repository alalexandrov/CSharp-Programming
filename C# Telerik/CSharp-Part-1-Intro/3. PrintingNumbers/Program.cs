using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrintingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            string result;
            int number = 5;
            for (int i = 0; i < 2; i++)
            {
                result = Convert.ToString(number, 2);
                Console.WriteLine(result);
                number += number - 1;
            }
                            
            

        }
    }
}

