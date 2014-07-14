using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AddingPositiveIntegersMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers represented as array
            int[] number1 = { 9, 2, 3, 4, 5, 6, 5 };
            int[] number2 = { 3, 4, 5, 2, 1, 5, 7 };

            //Tests with nums with 10 000 digits
            //number1 = new int[10000];
            //number2 = new int[10000];
            //number1[0] = 9;
            //number2[0] = 9;
            //number1[9999] = 9;
            //number2[9999] = 9;

            int[] Sum = SumInt(number1, number2);
            Console.WriteLine("First number: {0}", string.Join("",number1.Reverse()));
            Console.WriteLine("Second number: {0}", string.Join("", number2.Reverse()));
            Console.WriteLine("Sum is: {0} ", string.Join("", Sum.Reverse()));
        }

        public static int[] SumInt(int[] number1, int[] number2)
        {
            if (number1 == null || number2 == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            // Get max and min numbers length
            int MaxLength = Math.Max(number1.Length, number2.Length);
            int MinLength = Math.Min(number1.Length, number2.Length);

            List<int> sum = new List<int>(MaxLength);

            //Sum units
            sum.Add((number1[0] + number2[0]) % 10);

            //Get remainder of sum;
            int remainder = (number1[0] + number2[0]) / 10;

            for (int i = 1; i < MinLength; i++)
            {
                sum.Add(((number1[i] + number2[i]) % 10) + remainder);
                remainder = (number1[i] + number2[i]) / 10;
            }

            //If number of digits of numbers are not equal
            if (MinLength != MaxLength)
            {
                //Find bigger number
                int[] ArrWithBiggerLength;

                if (number1.Length == MaxLength)
                {
                    ArrWithBiggerLength = number1;
                }
                else
                {
                    ArrWithBiggerLength = number2;
                }

                //Add remaining digits 
                for (int i = MinLength; i < MaxLength; i++)
                {
                    sum.Add(((ArrWithBiggerLength[i] + remainder) % 10));
                    remainder = (ArrWithBiggerLength[i] + remainder) / 10;
                }
            }

            if (remainder != 0)
            {
                sum.Add(remainder);
            }

            return sum.ToArray();
        }
    }
}
