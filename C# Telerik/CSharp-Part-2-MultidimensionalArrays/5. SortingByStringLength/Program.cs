using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortingByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Arr = { "aaa", "bb", "c" };

            Console.WriteLine("Array: {0}", string.Join(", ", Arr));

            //Sort Array be string length

            //Arr = Arr.OrderBy((x) => x.Length).ToArray<string>();
            Array.Sort(Arr, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Sorted Array by length: {0}", string.Join(", ", Arr));
        }
    }
}
