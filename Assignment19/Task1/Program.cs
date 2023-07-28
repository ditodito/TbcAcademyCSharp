// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Random rnd = new Random();
int[] numbers = new int[10_000_000];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 10);
}

Console.WriteLine("Main thread: " + Thread.CurrentThread.ManagedThreadId);
int res = 0;


ParameterizedThreadStart d1 = SumNumbers;
Thread[] threads = new Thread[10];
for(int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(d1);
}

Stopwatch s = Stopwatch.StartNew();

for (int i = 0; i < threads.Length; i++)
{
    int f = i * (numbers.Length / threads.Length);
    int t = f + (numbers.Length / threads.Length);
    threads[i].Start(f + "," + t);
    threads[i].Join();
}

long e = s.ElapsedMilliseconds;
Console.WriteLine("{0} in miliseconds {1}", res, e);


/*
Stopwatch s = Stopwatch.StartNew();

ParameterizedThreadStart d1 = SumNumbers;
Thread s1 = new Thread(d1);
Thread s2 = new Thread(d1);
s1.Start("0,5000000");
s2.Start("5000000,10000000");
s1.Join();
s2.Join();

long e = s.ElapsedMilliseconds;
Console.WriteLine("{0} in miliseconds {1}", res, e);
 */

void SumNumbers(object interval)
{
    string[] inter = ((string)interval).Split(",");
    int fr = int.Parse(inter[0]);
    int to = int.Parse(inter[1]);
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