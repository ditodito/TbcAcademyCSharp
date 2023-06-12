// See https://aka.ms/new-console-template for more information
using System.Data;

void initProgram() {
    int row1 = getDemintion("first", "row");
    int col1 = getDemintion("first", "col");
    int row2 = getDemintion("second", "row");
    int col2 = getDemintion("second", "col");

    if (col1 != row2)
    {
        Console.WriteLine("First matrix col number {0} number not equal secodn matrix row {1} number", col1, row2);
        initProgram();
    }

    int[,] matrix1 = fillMatrix(row1, col1, "first");
    int[,] matrix2 = fillMatrix(row2, col2, "second");
    int[,] multMatrix = getMultMatrix(matrix1, matrix2);

    Console.WriteLine(getMatrixAsString(matrix1));
    Console.WriteLine(getMatrixAsString(matrix2));
    Console.WriteLine(getMatrixAsString(multMatrix));
}

initProgram();

int getDemintion(string matrixName, string type)
{
    Console.WriteLine("Enter {0} matrix {1} number:", matrixName, type);

    int result;
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        Console.WriteLine("Invalid {0} number, try again:", type);
    }

    return result;
}

int[,] fillMatrix(int row, int col, string matrixName) {
    int[,] result = new int[row, col];

    Console.WriteLine("Fill {0} matrix:", matrixName);
    
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            while (!int.TryParse(Console.ReadLine(), out result[i,j]))
            {
                Console.WriteLine("Invalid number, try again:");
            }
        }
    }

    return result;
}

int[,] getMultMatrix(int[,] matrix1, int[,] matrix2) {
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            int el = 0; ;
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                //Console.WriteLine(ar1[i, l] + " " + ar2[l,k]);
                el += matrix1[i, l] * matrix2[l, k];
            }
            //Console.WriteLine("===" + t);
            result[i, k] = el;
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