// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

Random rnd = new Random();
int[] numbers = new int[10_000_0000];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 5);
}

Console.WriteLine("Main thread: " + Thread.CurrentThread.ManagedThreadId);
int res = 0;
int d = 0;

Stopwatch s = Stopwatch.StartNew();

Task[] tl = new Task[10];
for (int i = 0; i < tl.Length; i++)
{
    //Task t = new Task(SumNumbers);
    //t.Start();
    int f = i * (numbers.Length / tl.Length);
    int t = f + (numbers.Length / tl.Length);
    tl[i] = Task.Run(() => SumNumbers(f, t));
    
}
Task.WaitAll(tl);
long e = s.ElapsedMilliseconds;
Console.WriteLine("{0} in miliseconds {1}", res, e);

void SumNumbers(int fr, int to)
{
    int localRes = 0;

    Stopwatch s = Stopwatch.StartNew();

    for (int i = fr; i < to; i++)
    {
        //Console.WriteLine(numbers[i] + " - " + Thread.CurrentThread.ManagedThreadId);
        localRes += numbers[i];
    }

    res += localRes;
    long e = s.ElapsedMilliseconds;
    Console.WriteLine("{0} thread elapsed time {1}", Thread.CurrentThread.ManagedThreadId, e);
}