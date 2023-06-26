using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MatrixUtil
    {
        public static double getDeterminanat(double[,] matrix)
        {
            double result = default;

            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) {
                result = getDeterminant2x2(matrix);
            }

            return result;
        }

        private static double getDeterminant2x2(double[,] matrix) {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        public static double[,] getAdj(double[,] matrix)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (i == 0 && j == 0) {
                        result[i, j] = matrix[1, 1];
                    }
                    else if (i == 1 && j == 1)
                    {
                        result[i, j] = matrix[0, 0];
                    } else
                    {
                        result[i, j] = -matrix[i, j];
                    }
                }
            }

            return result;
        }
    }
}
