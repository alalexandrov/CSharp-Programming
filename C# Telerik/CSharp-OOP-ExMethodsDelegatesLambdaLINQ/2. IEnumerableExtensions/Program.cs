using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static int GetSum(this IEnumerable<int> elements)
        {
            int Sum = 0;
            foreach (var elem in elements)
            {
                Sum += elem;
            }

            return Sum;
        }

        public static long GetProduct(this IEnumerable<int> elements)
        {
            int Product = 1;
            foreach (var elem in elements)
            {
                Product *= elem;
            }

            return Product;
        }

        public static double GetAvg<T>(this IEnumerable<int> elements)
        {
            double sum = 0;
            foreach (var elem in elements)
            {
                sum += elem;
            }

            return sum / elements.Count<int>();
        }
        public static T GetMax<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            T Max = elements.First<T>();
            foreach (var elem in elements)
            {
                if (elem.CompareTo(Max) == 1)
                {
                    Max = elem;
                }
            }

            return Max;
        }

        public static T GetMin<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            T Min = elements.First<T>();
            foreach (var elem in elements)
            {
                if (elem.CompareTo(Min) == -1)
                {
                    Min = elem;
                }
            }

            return Min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> names = new List<string>() { "Zebra", "Petq", "Alex" };

            Console.WriteLine("Numbers: {0}", string.Join(", ", numbers));
            Console.WriteLine("Sum of numebers is: {0}", numbers.GetSum());
            Console.WriteLine("The product of numbers is: {0}", numbers.GetProduct());
            Console.WriteLine("Max number is: {0}", numbers.GetMax<int>());
            Console.WriteLine("Min number is: {0}", numbers.GetMin<int>());
            Console.WriteLine("Average of number is: {0}", numbers.GetAvg<int>());

            Console.WriteLine("\nNames: {0}", string.Join(", ", names));
            Console.WriteLine("Max name (lex) is: {0}", names.GetMax<string>());
            Console.WriteLine("Min name (lex) is: {0}", names.GetMin<string>());
        }
    }
}
