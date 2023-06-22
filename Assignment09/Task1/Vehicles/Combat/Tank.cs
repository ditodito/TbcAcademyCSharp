using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Combat
{
    public class Tank : Combat
    {
        private bool _hasLaserSystem;

        public Tank() : this(8) { }

        public Tank(int numberOfSeats) : this(numberOfSeats, 80) { }

        public Tank(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 6) { }

        public Tank(int numberOfSeats, int maxSpeed, int numberOfWeapons) : this(numberOfSeats, maxSpeed, numberOfWeapons, true) { }

        public Tank(int numberOfSeats, int maxSpeed, int numberOfWeapons, bool hasLaserSystem) : base(numberOfSeats, maxSpeed, numberOfWeapons) {
            _hasLaserSystem = hasLaserSystem;
        }

        public bool HasLaserSystem
        {
            get { return _hasLaserSystem; }
            set { _hasLaserSystem = value; }
        }

        public override void move()
        {
            Console.WriteLine("Tank moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Tank breaking...");
        }

        public override void shoot()
        {
            Console.WriteLine("Tank shooting...");
        }

        public void activateLaserMode()
        {
            if (_hasLaserSystem)
            {
                Console.WriteLine("Activating laser mode...");
            }
        }
    }
}
