using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Consumer
{
    public class Motorcycle : Engine
    {
        private bool _isSportType;

        public Motorcycle() : this(5) { }

        public Motorcycle(int numberOfSeats) : this(numberOfSeats, 240) { }

        public Motorcycle(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 4) { }

        public Motorcycle(int numberOfSeats, int maxSpeed, int numbersOfWheel) 
            : this(numberOfSeats, maxSpeed, numbersOfWheel, Enums.Enums.FuelType.Oil) { }

        public Motorcycle(int numberOfSeats, int maxSpeed, int numbersOfWheel, Enums.Enums.FuelType fuelType)
            : this(numberOfSeats, maxSpeed, numbersOfWheel, fuelType, true) { }

        public Motorcycle(int numberOfSeats, int maxSpeed, int numbersOfWheel, Enums.Enums.FuelType fuelType, bool isSportType) :
            base(numberOfSeats, maxSpeed, numbersOfWheel, fuelType)
        {
            _isSportType = isSportType;
        }

        public bool IsSportType
        {
            get { return _isSportType; } 
            set { _isSportType = value; }
        }

        public void activateExtrimMode() {
            if (_isSportType)
            {
                Console.WriteLine("Activating extrim mode...");
            }
        }

        public void move()
        {
            Console.WriteLine("Motorcycle moving...");
        }
    }
}
