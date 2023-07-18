// See https://aka.ms/new-console-template for more information
using Task1;

Console.WriteLine("Hello, World!");

/*List<string> ll = new List<string>() { "dito1", "dito2", "dito3" };

using (IEnumerator<string> en = ll.GetEnumerator())
{
    while(en.MoveNext())
    {
        Console.WriteLine(en.Current);
    }
}

foreach(int d in GetDut()) {
    Console.WriteLine(d);
    if (d == 5)
    {
        return;
    }

}


IEnumerable<int> GetDut()
{
    int counter = 0;

    while(counter <= 10)
    {
        yield return counter;
        counter++;
    }
}*/

try {
    MyList<int> ml = new MyList<int>();
    Console.WriteLine(ml.Count());
    ml.Add(1);
    Console.WriteLine(ml.Count());
    ml.Add(2);
    Console.WriteLine(ml.Count());
    ml.Add(3);
    Console.WriteLine(ml.Count());
    ml.AddRange(new int[] {4, 5, 6});
    Console.WriteLine(ml.Count());

/*    Predicate<int> pred = t => t == 1;
    int t = ml.Find(pred);
    Console.WriteLine(t);

    Func<int, bool> func = t => t == 3;
    IEnumerable<int> l = ml.Where(func);
    foreach (int i in l)
    {
        Console.WriteLine(i);
    }*/

    //Console.WriteLine(ml.Single());
    //Console.WriteLine(ml.Single(t => t == 1));
    //Console.WriteLine(ml.SingleOrDefault());
    //Console.WriteLine(ml.SingleOrDefault(t => t == 17));

    foreach (int i in ml.GetEnumerable())
    {
        Console.WriteLine(i);
    }

} 
catch(InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
