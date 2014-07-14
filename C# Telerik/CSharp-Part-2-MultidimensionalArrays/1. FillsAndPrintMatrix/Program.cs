using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillsAndPrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read valid size of matrix
            string input = "";
            int number = 0;

            do
            {
                Console.Write("Enter valid int.(N > 0) for size a matrix: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out number));

            int[,] matrix1 = new int[number, number];
            int[,] matrix2 = new int[number, number];
            int[,] matrix3 = new int[number, number];

            //Fills first matrix
            int count = 1;
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    matrix1[col, row] = count;
                    count++;
                }
            }

            Console.WriteLine("\nMatrix A\n");
            PrintMatrix(matrix1);

            //Fills second matrix
            count = 1;
            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix2.GetLength(1); col++)
                    {
                        matrix2[col, row] = count;
                        count++;
                    }
                }
                else
                {
                    for (int col = matrix2.GetLength(1) - 1; col > -1; col--)
                    {
                        matrix2[col, row] = count;
                        count++;
                    }
                }
            }

            Console.WriteLine("Matrix B\n");
            PrintMatrix(matrix2);


            //Fills third matrix
            count = 1;
            for (int row = matrix3.GetLength(0) - 1; row > -1; row--)
            {
                for (int col = 0; row + col < matrix3.GetLength(0); col++)
                {
                    matrix3[row + col, col] = count;
                    count++;
                }
            }

            for (int col = 1; col < matrix3.GetLength(1); col++)
            {
                for (int row = 0; row + col < matrix3.GetLength(1); row++)
                {
                    matrix3[row, row + col] = count;
                    count++;
                }
            }

            Console.WriteLine("Matrix C\n");
            PrintMatrix(matrix3);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col].ToString().PadRight(4, ' '));
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
    }
}
