// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Task2;

Console.WriteLine("Hello, World!");


ElectricCar tesla3 = new ElectricCar("Tesla 3", 20218);
ElectricCar tesla6 = new ElectricCar("Tesla 6", 2020);
ElectricCar tesla9 = new ElectricCar("Tesla 9", 2022);
ElectricCar tesla12 = new ElectricCar("Tesla 12", 2024);

//Thread t1 = new Thread(tesla3.Charge);
//Thread t2 = new Thread(tesla6.Charge);
//t1.Start();
//t2.Start();
//t1.Join();
//t2.Join();
//tesla3.Charge();
//tesla6.Charge();

ChargeElectricCars(new List<ElectricCar> { tesla3, tesla6, tesla9, tesla12 });

void ChargeElectricCars(IEnumerable<ElectricCar> cars)
{
    Task[] tl = new Task[cars.Count()];

    Stopwatch sw = Stopwatch.StartNew();

    for(int i = 0; i < cars.Count(); i++)
    {
        //tl[i] = new Task(cars.ElementAt(i).Charge);
        //tl[i].Start();
        tl[i] = Task.Run(cars.ElementAt(i).Charge);
        //cars.ElementAt(i).Charge();
    }

    Task.WaitAll(tl);
    Console.WriteLine("Elapsed time {0}", sw.ElapsedMilliseconds);
}

Console.WriteLine("hello");
