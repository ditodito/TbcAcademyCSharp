using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Consumer
{
    public class Jeep : Engine
    {
        private bool _isPickup;

        public Jeep() : this(5) { }

        public Jeep(int numberOfSeats) : this(numberOfSeats, 240) { }

        public Jeep(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 4) { }

        public Jeep(int numberOfSeats, int maxSpeed, int numbersOfWheel) 
            : this(numberOfSeats, maxSpeed, numbersOfWheel, Enums.Enums.FuelType.Oil, false) { }

        public Jeep(int numberOfSeats, int maxSpeed, int numbersOfWheel, bool isPickup) 
            : this(numberOfSeats, maxSpeed, numbersOfWheel, Enums.Enums.FuelType.Oil, isPickup) { }

        public Jeep(int numberOfSeats, int maxSpeed, int numbersOfWheel, Enums.Enums.FuelType fuelType, bool isPickup) :
            base(numberOfSeats, maxSpeed, numbersOfWheel, fuelType) {
            _isPickup = isPickup;
        }

        public bool IsPickup
        {
            get { return _isPickup; } 
            set { _isPickup = value; }
        }

        public void activate4x4System() {
            Console.WriteLine("Activating 4x4 system...");
        }
    }
}
