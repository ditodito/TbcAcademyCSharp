using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private int _numberOfSeats;

        private int _maxSpeed;

        public Vehicle(int numberOfSeats, int maxSpeed)
        {
            _numberOfSeats = numberOfSeats;
            _maxSpeed = maxSpeed;
        }

        public int NumberOfSeats { get { return _numberOfSeats; } }

        public int MaxSpeed { get { return _maxSpeed; } }

        public virtual void move()
        {
            Console.WriteLine("Vehicle moving...");
        }

        public virtual void breaking()
        {
            Console.WriteLine("Vehicle breaking...");
        }
    }
}
