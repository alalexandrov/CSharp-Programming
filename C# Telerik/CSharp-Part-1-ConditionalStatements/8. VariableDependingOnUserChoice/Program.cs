using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.VariableDependingOnUserChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter '1' for entering integer variable");
            Console.WriteLine("Enter '2' for entering double variable");
            Console.WriteLine("Enter '3' for entering string variable");

            bool IsValidChoise = true;
            do
            {
                Console.Write("Your choice is: ");
                string ChoiseInput = Console.ReadKey().KeyChar.ToString();

                switch (ChoiseInput)
                {
                    case "1":
                        string IntegerInput = "";
                        int IntegerNumber = 0;
                        do
                        {
                            Console.Write("\nEnter valid integer value: ");
                            IntegerInput = Console.ReadLine();
                        } while (!int.TryParse(IntegerInput, out IntegerNumber));

                        int NewIntegerValue = IntegerNumber + 1;
                        Console.WriteLine("The new integer value is: {0}", NewIntegerValue);
                        IsValidChoise = true;
                        break;
                    case "2":
                        string DoubleInput = "";
                        int DoubleNumber = 0;
                        do
                        {
                            Console.Write("\nEnter valid double value: ");
                            DoubleInput = Console.ReadLine();
                        } while (!int.TryParse(DoubleInput, out IntegerNumber));

                        int NewDoubleValue = DoubleNumber + 1;
                        Console.WriteLine("The new double value is: {0}", NewDoubleValue);
                        IsValidChoise = true;
                        break;
                    case "3":
                        Console.Write("\nEnter string value: ");
                        string NewStringValue = Console.ReadLine() + "*";
                        Console.WriteLine("The new string value is: {0}", NewStringValue);
                        IsValidChoise = true;
                        break;
                    default: Console.WriteLine("\nWrong choice. Must be 1, 2, or 3 !!!");
                        IsValidChoise = false;
                        break;
                }

            } while (!IsValidChoise);
        }
    }
}
