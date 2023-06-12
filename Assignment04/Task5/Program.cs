// See https://aka.ms/new-console-template for more information

using System.Drawing;

Console.WriteLine("==Determinant Calulator==\nChoose matrix size:\n1. 2x2\n2. 3x3");
int matrixSize;

while (!int.TryParse(Console.ReadLine(), out matrixSize) || !(matrixSize == 1 || matrixSize == 2))
{
    Console.WriteLine("Invalid matrix size, try again:");
}

Console.WriteLine("Enter elements..");

int[,] matrix = generateMatrix(matrixSize + 1);

Console.WriteLine("You entered matrix:\n{0}", getMatrixAsString(matrix));

Console.WriteLine("Determinant is: {0}", getDeterminant(matrix));

int[,] generateMatrix(int size)
{
    int[,] result = new int[size,size];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.WriteLine("[{0}][{1}]:", i, j);
            while (!int.TryParse(Console.ReadLine(), out result[i, j]))
            {
                Console.WriteLine("Invalid number, try again:");
            }
        }
    }

    return result;
}

string getMatrixAsString(int[,] matrix)
{
    string result = "";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j] + " ";
        }

        result += "\n";
    }

    return result;
}

int getDeterminant(int[,] matrix)
{
    int result = 0;

    if (matrix.GetLength(0) == 2)
    {
        result = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
    else if (matrix.GetLength(0) == 3)
    {
        result = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                 matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                 matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    return result;
}