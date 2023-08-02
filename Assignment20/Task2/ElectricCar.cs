using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ElectricCar
    {
        public ElectricCar(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public string Model { get; set; }

        public int Year { get; set; }

        public int BatteryLevel { get; set; }

        public void Charge()
        {
            while (BatteryLevel < 100) {
                BatteryLevel += 5;
                Console.WriteLine("Batart level {0} of car {1} in thread {2}", BatteryLevel, Model, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10000);
            }
        }
    }
}
