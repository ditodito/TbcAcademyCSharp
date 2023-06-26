// See https://aka.ms/new-console-template for more information
using System.Numerics;
using Task1;

Console.WriteLine("Hello, World!");

double[,] d1 = { { 3, 5 }, { -7, 2 } };
Matrix m1 = new Matrix(d1);
Console.WriteLine(m1.ToString());
Console.WriteLine("========");

/*double[,] d11 = { { 0, 1 }, { 3, 2 } };
Matrix m11 = new Matrix(d11);
Console.WriteLine(m1.Equals(m11));*/
double d = m1;
Console.WriteLine(d);

double[,] d2 = { { -1, 3 }, { 0, 5 } };
Matrix m2 = new Matrix(d2);
Console.WriteLine(m2.ToString());
Console.WriteLine("========");

Matrix m3 = m1 + m2;
Console.WriteLine(m3.ToString());
Console.WriteLine("========");

Matrix m4 = m1 - m2;
Console.WriteLine(m4.ToString());
Console.WriteLine("========");

Matrix m5 = m1 * m2;
Console.WriteLine(m5.ToString());
Console.WriteLine("========");

//double[,] d8 = new double[,] { { 3, 5 }, { -7, 2 } };
//Matrix m8 = new Matrix(d8);
//Console.WriteLine(m8.ToString());
//Console.WriteLine("========");

Matrix m6 = +m1;
Console.WriteLine(m6.ToString());

