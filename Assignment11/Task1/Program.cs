// See https://aka.ms/new-console-template for more information
using Task1;

Console.WriteLine("Hello, World!");

IntegerMath im = new IntegerMath();
Console.WriteLine(im.Add(1, 2));
Console.WriteLine(im.Substract(1, 2));
Console.WriteLine(im.Multiply(1, 2));

DoubleMath dm = new DoubleMath();
Console.WriteLine(dm.Add(1, 2));
Console.WriteLine(dm.Substract(1, 2));
Console.WriteLine(dm.Multiply(1, 2));
