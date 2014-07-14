using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TheLongestSeuenceOfEqElem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fills third matrix
            string[,] matrix =
                {
                    { "ha", "fifi", "ho", "hi"},
                    { "fo", "ha", "hi", "xx"},
                    { "xxx", "ho", "ha", "xx", }           
                };

            //matrix3 = new int[5,10];
            int len = 1;
            int maxLen = 0;
            string maxLenElem = "";
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            //Scaning by len of equal elements

            //Scaning left diagonal
            for (int row = rows - 1; row > -1; row--)
            {
                for (int col = 0; row + col < rows - 1 && col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row + col, col] == matrix[row + col + 1, col + 1])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxLenElem = matrix[row + col, col];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                len = 1;
            }

            for (int col = 1; col < cols; col++)
            {
                for (int row = 0; row + col < cols - 1 && row < rows - 1; row++)
                {     
                    if (matrix[row, row + col] == matrix[row + 1, row + col + 1])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxLenElem = matrix[row, row + col];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                len = 1;
            }

            //Scaning right diagonal 
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; row - col > 0 && col < cols - 1; col++)
                {     
                    if (matrix[row - col, col] == matrix[(row - col) - 1, col + 1])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxLenElem = matrix[row - col, col];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                len = 1;
            }

            for (int col = 1; col < cols; col++)
            {
                for (int row = rows - 1; row > 0 && (rows - row) + col < cols; row--)
                {
                    if (matrix[row, (rows - row - 1) + col] == matrix[row - 1, (rows - row) + col])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxLenElem = matrix[row, (rows - row - 1) + col];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                len = 1;
            }

            //Scaning by columns
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxLenElem = matrix[row, col];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                len = 1;
            }

            //Scaning by rows
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxLenElem = matrix[row, col];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                len = 1;
            }

            Console.WriteLine("The matrix is:\n");
            PrintMatrix(matrix);
           
            Console.Write("The longest sequence of equal elements is: ");

            for (int i = 0; i < maxLen; i++)
            {
                Console.Write("{0} ", maxLenElem);
            }
            Console.WriteLine();

        }


        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" {0} ", matrix[row, col].ToString().PadRight(4, ' '));
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
    }
}
