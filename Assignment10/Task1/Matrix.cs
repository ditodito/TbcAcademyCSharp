using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        private double[,] _elements = new double[2, 2];

        public Matrix(double[,] elements)
        {
            _elements = elements;
        }

        public double[,] Elements { get { return this._elements; } }

        public static implicit operator double(Matrix m)
        {
            double result = 0;

            for (int i = 0; i < m.Elements.GetLength(0); i++)
            {
                for (int j = 0; j < m.Elements.GetLength(1); j++)
                {
                    result += m.Elements[i, j];
                }
            }

            return result;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Elements.GetLength(0) != m2.Elements.GetLength(0) || m1.Elements.GetLength(1) != m2.Elements.GetLength(1))
            {
                throw new Exception($"Matrixes are incopatible, they musb be same size");
            }

            double[,] result = new double[m1.Elements.GetLength(0), m1.Elements.GetLength(1)];

            for (int i = 0; i < m1.Elements.GetLength(0); i++)
            {
                for (int j = 0; j < m1.Elements.GetLength(1); j++)
                {
                    result[i, j] = m1.Elements[i, j] + m2.Elements[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Elements.GetLength(0) != m2.Elements.GetLength(0) || m1.Elements.GetLength(1) != m2.Elements.GetLength(1))
            {
                throw new Exception($"Matrixes are incopatible, they musb be same size");
            }

            double[,] result = new double[m1.Elements.GetLength(0), m1.Elements.GetLength(1)];

            for (int i = 0; i < m1.Elements.GetLength(0); i++)
            {
                for (int j = 0; j < m1.Elements.GetLength(1); j++)
                {
                    result[i, j] = m1.Elements[i, j] - m2.Elements[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {

            if (m1.Elements.GetLength(0) != m2.Elements.GetLength(1))
            {
                throw new Exception($"Matrixes are incopatible, Matrix1 row number {m1.Elements.GetLength(0)} not equal Matrix2 col number {m2.Elements.GetLength(1)}");
            }

            double[,] result = new double[m1.Elements.GetLength(0), m2.Elements.GetLength(1)];


            for (int i = 0; i < m1.Elements.GetLength(0); i++)
            {
                for (int k = 0; k < m2.Elements.GetLength(1); k++) {
                    double d = 0;

                    for (int j = 0; j < m2.Elements.GetLength(0); j++)
                    {
                        d += m1.Elements[i, j] * m2.Elements[j, k];
                    }

                    result[i, k] = d;
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator +(Matrix m)
        {
            double[,] result = new double[m.Elements.GetLength(0), m.Elements.GetLength(1)];

            double det = 1 / MatrixUtil.getDeterminanat(m._elements);
            double[,] adjMatrix = MatrixUtil.getAdj(m._elements);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = adjMatrix[i, j] * det;
                }
            }

            return new Matrix(result);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < _elements.GetLength(0); i++)
            {
                for (int j = 0; j < _elements.GetLength(1); j++)
                {
                    result.Append(_elements[i, j]);

                    if (j != _elements.GetLength(1) - 1)
                    {
                        result.Append(" ");
                    }
                }

                if (i != _elements.GetLength(0) - 1)
                {
                    result.Append("\n");
                }
            }

            return result.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Matrix)
            {
                return false;
            }

            Matrix matrix = (Matrix) obj;

            if (_elements.GetLength(0) != matrix.Elements.GetLength(0) || _elements.GetLength(1) != matrix.Elements.GetLength(1))
            {
                return false;
            }
            
            for (int i = 0; i < _elements.GetLength(0); i++)
            {
                for (int j = 0; j < _elements.GetLength(1); j++)
                {
                    if (_elements[i, j] != matrix.Elements[i, j]) {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
