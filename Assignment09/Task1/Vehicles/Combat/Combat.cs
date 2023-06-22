using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Combat
{
    public abstract class Combat : Vehicle
    {
        private int _numberOfWeapons;

        //public CombatCar() : this(8) { }

        //public CombatCar(int numberOfSeats) : this(8, 80) { }

        //public CombatCar(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 1) { }

        public Combat(int numberOfSeats, int maxSpeed, int numbersOfWeapons) : base(numberOfSeats, maxSpeed)
        {
            _numberOfWeapons = numbersOfWeapons;
        }

        public int NumberOfWeapons { get { return _numberOfWeapons; } }

        public override void move()
        {
            Console.WriteLine("Combat car moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Combat car breaking...");
        }

        public virtual void shoot()
        {
            Console.WriteLine("Combat car shooting...");
        }
    }
}
