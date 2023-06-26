// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");

Storage<int> ist = new Storage<int>();
Console.WriteLine(ist.Value);
ist.Add(87);
Console.WriteLine(ist.Value);
ist.Remove();
Console.WriteLine(ist.Value);
ist.Update(97);
Console.WriteLine(ist.Value);
Console.WriteLine("======");

Storage<double> dst = new Storage<double>();
Console.WriteLine(dst.Value);
dst.Add(87.87);
Console.WriteLine(dst.Value);
dst.Remove();
Console.WriteLine(dst.Value);
dst.Update(97.87);
Console.WriteLine(dst.Value);
Console.WriteLine("======");

Storage<bool> bst = new Storage<bool>();
Console.WriteLine(bst.Value);
bst.Add(true);
Console.WriteLine(bst.Value);
bst.Remove();
Console.WriteLine(bst.Value);
bst.Update(false);
Console.WriteLine(bst.Value);
Console.WriteLine("======");

Storage<string> sst = new Storage<string>();
Console.WriteLine(sst.Value);
sst.Add("Test 1");
Console.WriteLine(sst.Value);
sst.Remove();
Console.WriteLine(sst.Value);
sst.Update("Test 2");
Console.WriteLine(sst.Value);
Console.WriteLine("======");

Storage<Person> pst = new Storage<Person>();
Console.WriteLine(pst.Value);
pst.Add(new Person("Test 1", 27));
Console.WriteLine(pst.Value);
pst.Remove();
Console.WriteLine(pst.Value);
pst.Update(new Person("Test 2", 87));
Console.WriteLine(pst.Value);
Console.WriteLine("======");
