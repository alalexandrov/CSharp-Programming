using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int NValue = 0;
                int XValue = 0;
                int YValue = 0;
                bool CheckValues = true;
                do
                {
                    CheckValues = true;
                    Console.Write("Enter integer number N [10 < N < 50]: ");
                    NValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("Now enter X and Y [X < Y] ");
                    Console.Write("X: ");
                    XValue = int.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    YValue = int.Parse(Console.ReadLine());

                    if (NValue < 10 || NValue > 50 || XValue > YValue)
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter values in intervals. Enter again !");
                        Console.WriteLine();
                        CheckValues = false;
                    }
                }
                while (!CheckValues);
                int[] InputNumbers = new int[NValue];
                Console.WriteLine("Now enter {0} values", NValue);
                for (int i = 0; i < InputNumbers.Length; i++)
                {
                    Console.Write("Enter element {0} : ", i + 1);
                    InputNumbers[i] = int.Parse(Console.ReadLine());
                }

                List<int> OutputNumbers = new List<int>();
                for (int i = 0; i < InputNumbers.Length; i++)
                {
                    if ((InputNumbers[i] > XValue && InputNumbers[i] < YValue) ||
                        (InputNumbers[i] > i) ||
                        (i % 3 == 0))
                    {
                        OutputNumbers.Add(InputNumbers[i]);
                    }
                }

                int Product = 1;
                int Sum = 0;
                foreach (var item in OutputNumbers)
                {
                    Sum += item;
                    Product *= item;
                }

                Console.WriteLine(new string('<', 20));
                Console.WriteLine("Input Values: {0}", string.Join(",", InputNumbers));
                Console.WriteLine("Ouput Values: {0}", string.Join(",", OutputNumbers));
                Console.WriteLine("The number of output elements is: {0}", OutputNumbers.Count);
                Console.WriteLine("The MAX output element is: {0}", OutputNumbers.Max());
                Console.WriteLine("The SUM of elements is: {0}", Sum);
                Console.WriteLine("The Product of elemements is: {0}", Product);
                
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format on input !!!");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
        }
    }
}


