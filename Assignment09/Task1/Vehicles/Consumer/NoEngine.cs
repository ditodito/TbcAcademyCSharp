using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Consumer
{
    public abstract class NoEngine : Consumer
    {
        private Enums.Enums.Material _material;

        //public NoEngineCar() : this(5) { }

        //public NoEngineCar(int numberOfSeats) : this(numberOfSeats, 240) { }

        //public NoEngineCar(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 4) { }

        //public NoEngineCar(int numberOfSeats, int maxSpeed, int numberOfWheel) : this(numberOfSeats, maxSpeed, 
        //numberOfWheel, Enums.Enums.Material.Alluminium) { }

        public NoEngine(int numberOfSeats, int maxSpeed, int numberOfWheel, Enums.Enums.Material material) :
            base(numberOfSeats, maxSpeed, numberOfWheel)
        {
            _material = material;
        }

        public Enums.Enums.Material FuelType
        {
            get { return _material; }
            set
            {
                _material = value;
            }
        }
    }
}
