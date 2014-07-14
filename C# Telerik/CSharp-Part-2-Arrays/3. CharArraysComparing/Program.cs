using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CharArraysComparing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = { 'a', 'b', 'c' };
            char[] secondArr = { 'a', 'b', 'a', 'd' };

            int minArrLength = Math.Min(firstArr.Length, secondArr.Length);

            //Comparing arrays letter by letter
            for (int i = 0; i < minArrLength; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine("First arr is before second arr lexicographically !");
                    return;
                }

                if (secondArr[i] < firstArr[i])
                {
                    Console.WriteLine("Second arr is before first arr lexicographically !");
                    return;
                }
            }

            //Comparing arrays length
            if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("First arr is before second arr lexicographically !");
            }
            else if (secondArr.Length < firstArr.Length)
            {
                Console.WriteLine("Second arr is before first arr lexicographically !");
            }
            else
            {
                Console.WriteLine("The arrays are equal !");
            }
           
        }
    }
}
