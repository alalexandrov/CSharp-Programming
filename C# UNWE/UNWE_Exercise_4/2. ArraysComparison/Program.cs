using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of first Array: ");
            int FirstArrayLength = int.Parse(Console.ReadLine());
            int[] FirstArray = new int[FirstArrayLength];
            for (int i = 0; i < FirstArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                FirstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter length of second Array Array: ");
            int SecondArrayLength = int.Parse(Console.ReadLine());
            int [] SecondArray = new int[SecondArrayLength];
            for (int i = 0; i < SecondArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                SecondArray[i] = int.Parse(Console.ReadLine());
            }

            if (FirstArray.SequenceEqual(SecondArray))
            {
                Console.WriteLine("Arrays are equal !");
            }
            else
            {
                Console.WriteLine("Arrays are not equal !");
            }

        }
    }
}
