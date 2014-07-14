using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetMaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            //Read numbers
            Console.WriteLine("Enter 3 valid integer numbers !");
            do
            {
                Console.Write("Enter first int. number: ");
                input = Console.ReadLine();
                Console.Write("Enter second int. number: ");
                input = Console.ReadLine();
                Console.Write("Enter third int. number: ");
                input = Console.ReadLine();
                Console.WriteLine();

            } while (!int.TryParse(input, out number1) && 
                !int.TryParse(input, out number2) &&
                !int.TryParse(input, out number3));

            //Get max number
            int MaxNum = GetMax(number1, GetMax(number2, number3));

            Console.WriteLine("The biggest entered num is: {0}", MaxNum);
        }

        public static int GetMax(int FirstNum, int SecondNum)
        {
            return FirstNum > SecondNum ? FirstNum : SecondNum;
        }
    }
}
