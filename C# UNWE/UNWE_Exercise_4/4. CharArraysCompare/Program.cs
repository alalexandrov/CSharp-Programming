using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] FirstArr = {'b', 'b', 'c'};
            char [] SecondArr = { 'a', 'b', 'c', 'e' };
            int length = 0;
            if (FirstArr.Length == SecondArr.Length)
            {
                length = FirstArr.Length;
            }
            else
	        {
                length = Math.Min(FirstArr.Length, SecondArr.Length);
	        }

            for (int i = 0; i < length; i++)
            {
                switch (FirstArr[i].CompareTo(SecondArr[i]))
                {
                    case -1: Console.WriteLine("First array is before second lexicographically."); return;
                    case 1: Console.WriteLine("Second array is before first lexicographically."); return;
                    default: break;
                }
            }

            if (FirstArr.Length < SecondArr.Length)
            {
                Console.WriteLine("First array is before second lexicographically.");
                return;
            }
            else if (SecondArr.Length < FirstArr.Length)
            {
                Console.WriteLine("Second array is before first lexicographically.");
                return;
            }
            else
            {
                Console.WriteLine("The arrays are same.");
            }
        }
    }
}
