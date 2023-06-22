using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Consumer
{
    public class Sedan : Engine
    {
        public Sedan() : this(5) { }

        public Sedan(int numberOfSeats) : this(numberOfSeats, 240) { }

        public Sedan(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 4) { }

        public Sedan(int numberOfSeats, int maxSpeed, int numbersOfWheel) : this(numberOfSeats, maxSpeed, numbersOfWheel, Enums.Enums.FuelType.Oil) { }

        public Sedan(int numberOfSeats, int maxSpeed, int numbersOfWheel, Enums.Enums.FuelType fuelType) :
            base(numberOfSeats, maxSpeed, numbersOfWheel, fuelType) { }

        public override void move()
        {
            Console.WriteLine("Sedan moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Sedan breaking...");
        }
    }
}
