using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Consumer
{
    internal class Bicycle : NoEngine
    {
        public Bicycle() : this(1) { }

        public Bicycle(int numbersOfSeats) : this(numbersOfSeats, 40) { }

        public Bicycle(int numbersOfSeats, int maxSpeed) : this(numbersOfSeats, maxSpeed, 2) { }

        public Bicycle(int numbersOfSeats, int maxSpeed, int numbersOfWheel) : 
            this(numbersOfSeats, maxSpeed, numbersOfWheel, Enums.Enums.Material.Alluminium) { }

        public Bicycle(int numbersOfSeats, int maxSpeed, int numbersOfWheel, Enums.Enums.Material material) :
            base(numbersOfSeats, maxSpeed, numbersOfWheel, material)
        { }

        public void spinPedals()
        {
            Console.WriteLine("Spining pedals...");
        }
    }
}
