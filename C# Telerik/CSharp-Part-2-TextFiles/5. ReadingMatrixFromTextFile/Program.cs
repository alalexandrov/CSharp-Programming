using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ReadingMatrixFromTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading input
                StreamReader reader = new StreamReader("..\\..\\Matrix.txt");
                int[,] matrix = ReadMatrix(reader);
                int MaxArea = MaxSumArea(matrix);

                //Writing output to another text file
                StreamWriter writer = new StreamWriter("..\\..\\Result.txt");
                using (writer)
                {
                    writer.WriteLine(MaxArea);
                }

                Console.WriteLine("The result is saved to Result.txt");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        public static int[,] ReadMatrix(StreamReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentException("Ivalid value for reader !!!");
            }

            using (reader)
            {
                //Reading first line (size of matrix)
                string Line = reader.ReadLine();
                int MatrixSize = int.Parse(Line);

                // Reading matrix    
                int[,] matrix = new int[MatrixSize, MatrixSize];
                string[] LineNumbers;
                char[] separator = { ' ' };

                for (int row = 0; row < MatrixSize; row++)
                {
                    Line = reader.ReadLine();
                    LineNumbers = Line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    for (int col = 0; col < MatrixSize; col++)
                    {
                        matrix[row, col] = int.Parse(LineNumbers[col]);
                    }
                }

                return matrix;
            }
        }
        public static int MaxSumArea(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("The given matrix can't be null !!!");
            }

            int AreaSize = 2;
            int RowLength = matrix.GetLength(0);
            int ColLength = matrix.GetLength(1);
            int CurrentSum = 0;
            int MaxSum = int.MinValue;

            for (int row = 0; row <= RowLength - AreaSize; row++)
            {
                for (int col = 0; col <= ColLength - AreaSize; col++)
                {
                    CurrentSum = matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1];

                    if (CurrentSum > MaxSum)
                    {
                        MaxSum = CurrentSum;
                    }
                }
            }

            return MaxSum;
        }
    }
}
