using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HowManyNumDividedByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start num: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter end num: ");
            int endNum = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("The count of numbers in interval [{0}, {1}] is: {2}", startNum, endNum, count);
        }
    }
}
