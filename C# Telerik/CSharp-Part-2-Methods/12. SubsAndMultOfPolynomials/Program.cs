using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubsAndMultOfPolynomials
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
            Console.WriteLine("Multiplied polynoms: {0}", PolynomToStr(MultiplyPoly(FirstPolynom, SecondPolynom)));
        }

        public static int[] MultiplyPoly(int[] first, int[] second)
        {
            int SumPolyLength = first.Length + second.Length - 1;
            int[] SumPolynom = new int[SumPolyLength];

            for (int i = 0; i < first.Length; i++)
            {
                if (i != 0)
                {
                    // Multiplying free member by other polynom members
                    for (int j = 0; j < second.Length; j++)
                    {
                        SumPolynom[j + i] += first[i] * second[j];
                    }
                }
                else
                {
                    //Mulplying not free members by other polynom members
                    for (int j = 0; j < second.Length; j++)
                    {
                        SumPolynom[j] = first[i] * second[j];
                    }
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
