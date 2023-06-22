using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Public
{
    public abstract class PublicVehicle : Vehicle
    {
        private int _lineNumber;

        public PublicVehicle(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) {}

        public int LineNumber { 
            get { return _lineNumber; } 
            set { _lineNumber = value; }
        }

        public override void move()
        {
            Console.WriteLine("Public car moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Public car breaking...");
        }

        public abstract void openDoor(); 
    }
}
