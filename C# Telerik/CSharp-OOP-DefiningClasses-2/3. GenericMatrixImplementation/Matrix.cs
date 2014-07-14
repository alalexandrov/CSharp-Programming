using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericMatrixImplementation
{
    public class Matrix<T>
    {
        private T[,] matrix;

        public int Rows
        {
            get
            {
                return matrix.GetLength(0);
            }
        }
        public int Cols
        {
            get
            {
                return matrix.GetLength(1);
            }
        }
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < this.matrix.GetLength(0) && col < this.matrix.GetLength(1))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid matrix index !");
                }
            }
            set
            {
                if (row < this.matrix.GetLength(0) && col < this.matrix.GetLength(1))
                {
                    matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid matrix index !");
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Rows == secondMatrix.Rows) &&
                (firstMatrix.Cols == secondMatrix.Cols))
            {
                int Rows = firstMatrix.Rows;
                int Cols = firstMatrix.Cols;

                Matrix<T> ResultMatrix = new Matrix<T>(Rows, Cols);
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Cols; col++)
                    {
                        ResultMatrix[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                    }
                }

                return ResultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrixes must with equal rows and cols");
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Rows == secondMatrix.Rows) &&
                (firstMatrix.Cols == secondMatrix.Cols))
            {
                int Rows = firstMatrix.Rows;
                int Cols = firstMatrix.Cols;

                Matrix<T> ResultMatrix = new Matrix<T>(Rows, Cols);
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Cols; col++)
                    {
                        ResultMatrix[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                    }
                }

                return ResultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrixes must with equal rows and cols");
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows == secondMatrix.Cols)
            {
                Matrix<T> ResultMatrix = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < secondMatrix.Cols; j++)
                    {
                        for (int k = 0; k < firstMatrix.Rows; k++)
                        {
                            ResultMatrix[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                        }
                    }
                }

                return ResultMatrix;
            }
            else
            {
                throw new ArgumentException("Number of columns in First Matrix is not equal to Number of rows in Second Matrix !");
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(this.matrix[row, col].ToString().PadRight(3,' '));
                }
                output.Append("\n");
            }

            return output.ToString();
        }
    }
}
