using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericMatrixImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            Matrix<int> matrix = new Matrix<int>(2, 2);
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            Matrix<int> matrix2 = new Matrix<int>(2, 2);
            matrix2[0, 0] = 1;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 3;
            matrix2[1, 1] = 4;

            Matrix<int> Sum = matrix + matrix2;
            Matrix<int> Diffence = matrix - matrix2;
            Matrix<int> Multiplication = matrix * matrix2;

            Console.WriteLine("First matrix");
            Console.WriteLine(matrix);
            Console.WriteLine("Second matrix");
            Console.WriteLine(matrix2);
            Console.WriteLine("--------------");

            Console.WriteLine("First + Second");
            Console.WriteLine(Sum);

            Console.WriteLine("First - Second");
            Console.WriteLine(Diffence);

            Console.WriteLine("First * Second");
            Console.WriteLine(Multiplication);
        }

    }
}
