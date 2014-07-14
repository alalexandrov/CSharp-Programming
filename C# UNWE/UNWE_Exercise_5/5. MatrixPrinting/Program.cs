using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = 4;
            int row = 4;
            int[,] FirstMatrix = new int[row, col];
            int[,] SecondMatrix = new int[row, col];
            int CellDigit = 1;

            //Filling first matrix
            for (int i = 0; i < FirstMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < FirstMatrix.GetLength(0); j++)
                {
                    FirstMatrix[j, i] = CellDigit;
                    CellDigit++;
                }
            }

            CellDigit = 1;

            //Filling second matrix
            for (int i = 0; i < SecondMatrix.GetLength(1); i++)
            {
                if (i % 2 == 0)
                {
                    
                    for (int j = 0; j < SecondMatrix.GetLength(0); j++)
                    {
                        SecondMatrix[j, i] = CellDigit;
                        CellDigit++;
                    }     
                }
                else
                {
                    for (int j = SecondMatrix.GetLength(0) - 1; j >= 0; j--)
                    {
                        SecondMatrix[j, i] = CellDigit;
                        CellDigit++;
                    }
                }
                
            }

            //Prints FirstMatrix
            for (int i = 0; i < FirstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                {
                    Console.Write(" {0} ", FirstMatrix[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Prints SecondMatrix
            for (int i = 0; i < SecondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                {
                    Console.Write(" {0} ", SecondMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
