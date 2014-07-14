using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[20];

            Console.WriteLine("The elements of array are:");

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i * 5;
                Console.WriteLine(Array[i]);
            }


        }
    }
}
