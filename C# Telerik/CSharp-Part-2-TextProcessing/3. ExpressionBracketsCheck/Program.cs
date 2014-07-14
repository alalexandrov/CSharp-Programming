using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExpressionBracketsCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)/5-d)";

            //Checking is brackets are correct
            Console.WriteLine("The brackets of expression {0} are correct ?: {1}", expression, IsBracketsCorrect(expression));
        }
        public static bool IsBracketsCorrect(string expression)
        {
            int counter = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }

                if (expression[i] == ')')
                {
                    counter--;
                }
            }

            return counter == 0;
        }
    }
}
