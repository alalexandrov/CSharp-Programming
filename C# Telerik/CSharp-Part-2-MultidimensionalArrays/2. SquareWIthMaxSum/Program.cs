using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SquareWIthMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = ReadMatrix();

            int CurrentSum = 0;
            int MaxSum = int.MinValue;
            int[,] squareMatrix = new int[3, 3];

            //Getting sum of square 3 x 3 
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    CurrentSum =
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +

                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +

                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (CurrentSum > MaxSum)
                    {
                        MaxSum = CurrentSum;
                        squareMatrix = new int[,]{
                        {matrix[row, col], matrix[row, col + 1],matrix[row, col + 2]},
                        {matrix[row + 1, col],matrix[row + 1, col + 1],matrix[row + 1, col + 2]},
                        {matrix[row + 2, col],matrix[row + 2, col + 1], matrix[row + 2, col + 2]},
                    };

                    }
                }
            }

            Console.WriteLine("\nEntered matrix is\n ");
            PrintMatrix(matrix);

            Console.WriteLine("\nThe square matrix 3 X 3 with max sum is\n");
            PrintMatrix(squareMatrix);

            Console.WriteLine("The sum of elements is: {0}", MaxSum);
        }

        public static int[,] ReadMatrix()
        {
            //Read valid matrix dimensions
            string input = "";
            int rows = 0;
            do
            {
                Console.Write("Enter matrix rows (N > 3): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out rows) || rows < 3);

            int cows = 0;
            do
            {
                Console.Write("Enter matrix cows (N > 3): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out cows) || cows < 3);

            int[,] matrix = new int[rows, cows];

            //Read valid matrix values
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    do
                    {
                        Console.Write("Enter int. value for [{0},{1}]: ", row + 1, col + 1);
                        input = Console.ReadLine();
                    } while (!int.TryParse(input, out matrix[row, col]));
                }
            }

            return (int[,])matrix.Clone();
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
