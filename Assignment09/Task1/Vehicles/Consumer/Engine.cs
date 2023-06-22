using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Enums;

namespace Task1.Vehicles.Consumer
{
    public abstract class Engine : Consumer
    {
        private Enums.Enums.FuelType _fuelType;

        //public EngineCar() : this(5) { }

        //public EngineCar(int numberOfSeats) : this(numberOfSeats, 240) { }

        //public EngineCar(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 4) { }

        //public EngineCar(int numberOfSeats, int maxSpeed, int numberOfWheel) : this(numberOfSeats, maxSpeed, numberOfWheel, Enums.Enums.FuelType.Oil) { }

        public Engine(int numberOfSeats, int maxSpeed, int numberOfWheel, Enums.Enums.FuelType fuelType) : 
            base(numberOfSeats, maxSpeed, numberOfWheel)
        {
            _fuelType = fuelType;
        }

        public Enums.Enums.FuelType FuelType
        {
            get { return _fuelType; }
            set
            {
                _fuelType = value;
            }
        }

        public void refueling()
        {
            Console.WriteLine("Refueling...");
        }
    }
}
