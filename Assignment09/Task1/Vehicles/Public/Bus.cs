using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Public
{
    internal class Bus : PublicVehicle
    {
        public Bus() : this(44) { }

        public Bus(int numberOfSeats) : this(numberOfSeats, 40) { }

        public Bus(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) { }

        public override void openDoor()
        {
            Console.WriteLine("Bus open door...");
        }

    }
}
