using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.VariableArgsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Array: {0}", string.Join(", ", numbers));
            Console.WriteLine("The max value is: {0}", GetMax(numbers));
            Console.WriteLine("The min value is: {0}", GetMin(numbers));
            Console.WriteLine("The average is: {0}", GetAvg(numbers));
            Console.WriteLine("The sum is: {0}", GetSum(numbers));
            Console.WriteLine("The product is: {0}", GetProduct(numbers));
        }
        public static int GetMin(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            int MinNum = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < MinNum)
                {
                    MinNum = numbers[i];
                }
            }

            return MinNum;
        }

        public static int GetMax(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            int MaxNum = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxNum)
                {
                    MaxNum = numbers[i];
                }
            }

            return MaxNum;
        }

        public static int GetSum(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static double GetAvg(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The given array can't be null or empty!");
            }

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static long GetProduct(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
