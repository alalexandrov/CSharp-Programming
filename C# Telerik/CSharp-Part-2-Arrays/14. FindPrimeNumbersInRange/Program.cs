using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.FindPrimeNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] Arr = new bool[1000];

            //Sieve of Eratosthenes algorithm
            double SqrtLength = Math.Sqrt(Arr.Length);
            int length = Arr.Length;

            for (int i = 0; i < length; i++)
            {
                Arr[i] = true;
            }
            

            for (int i = 2; i < SqrtLength; i++)
            {
                if (Arr[i] == true)
                {
                    for (int j = i*i; j < length; j += i)
                    {
                        Arr[j] = false;
                    }
                }
            }

            for (int i = 2; i < length; i++)
            {
                if (Arr[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
