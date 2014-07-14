using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingTwoPolynomialsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polynoms represented as array
            int[] FirstPolynom = { -3, 1, 3 };
            int[] SecondPolynom = { -1, 1 };

            Console.WriteLine("First polynom: {0}", PolynomToStr(FirstPolynom));
            Console.WriteLine("Second polynom: {0}", PolynomToStr(SecondPolynom));

            Console.WriteLine("Sum polynom: {0}", PolynomToStr(AddPolinomials(FirstPolynom, SecondPolynom)));

        }

        public static int[] AddPolinomials(int[] first, int[] second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentException("Given array can't be null !");
            }

            //Getting min and max polynomials length
            int MinPolyLength = Math.Min(first.Length, second.Length);
            int MaxPolyLength = Math.Max(first.Length, second.Length);

            int[] SumPolynom = new int[MaxPolyLength];

            //Summing polynoms 
            for (int i = 0; i < MinPolyLength; i++)
            {
                SumPolynom[i] = first[i] + second[i];
            }

            //If number of polynomials members are not equal
            if (MinPolyLength != MaxPolyLength)
            {
                //Find bigger polynom
                int[] BiggerPolynom;
                if (first.Length == MaxPolyLength)
                {
                    BiggerPolynom = first;
                }
                else
                {
                    BiggerPolynom = second;
                }

                //Add remaining members 
                for (int i = MinPolyLength; i < MaxPolyLength; i++)
                {
                    SumPolynom[i] = BiggerPolynom[i];
                }
            }

            return SumPolynom;
        }

        public static string PolynomToStr(int[] polynom)
        {
            if (polynom == null)
            {
                throw new ArgumentException("Given array can't be null !");
            }

            StringBuilder output = new StringBuilder();

            for (int i = polynom.Length - 1; i > 0; i--)
            {

                if (i != polynom.Length - 1 && polynom[i] > 0)
                {
                    output.Append("+");
                }

                output.Append(polynom[i] + "X");

                if (i != 1)
                {
                    output.Append("^" + i + " ");
                }
            }

            if (polynom[0] > 0)
            {
                output.Append(" +");
            }
            else
            {
                output.Append(" ");
            }

            output.Append(polynom[0]);
            return output.ToString();
        }


    }
}
