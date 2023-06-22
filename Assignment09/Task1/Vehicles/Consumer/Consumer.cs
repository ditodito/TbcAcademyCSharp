using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Enums;

namespace Task1.Vehicles.Consumer
{
    public abstract class Consumer : Vehicle
    {
        private int _numberOfWheel;

        //public ConsumerCar(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 4) {}

        public Consumer(int numberOfSeats, int maxSpeed, int numberOfWheel) : base(numberOfSeats, maxSpeed)
        {
            _numberOfWheel = numberOfWheel;
        }

        public int NumberOfWheel { get { return _numberOfWheel; } }

        public override void move()
        {
            Console.WriteLine("Consumer car moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Consumer car breaking...");
        }
    }
}
