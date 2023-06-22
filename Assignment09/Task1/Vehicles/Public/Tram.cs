using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Public
{
    internal class Tram : PublicVehicle
    {
        public Tram() : this(44) { }

        public Tram(int numberOfSeats) : this(numberOfSeats, 40) { }

        public Tram(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) { }

        public override void move()
        {
            Console.WriteLine("Tram movign on gauges...");
        }

        public override void openDoor()
        {
            Console.WriteLine("Tram open door...");
        }

    }
}
