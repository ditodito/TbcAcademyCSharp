// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");

Triangle t1 = new Triangle(2.7);
Triangle t2 = new Triangle(2.6);

Console.WriteLine(t1 == t2);
Console.WriteLine(t1 != t2);
Console.WriteLine(t1 > t2);
Console.WriteLine(t1 < t2);

Triangle t3 = t1 + t2;
Console.WriteLine(t3.Area());

Triangle t4 = (Triangle)2.35;
Console.WriteLine(t4.Area());
