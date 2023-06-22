using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Combat
{
    public class Beter : Combat
    {
        private bool _canSwimm;

        public Beter() : this(12) { }

        public Beter(int numberOfSeats) : this(numberOfSeats, 120) { }

        public Beter(int numberOfSeats, int maxSpeed) : this(numberOfSeats, maxSpeed, 3) { }

        public Beter(int numberOfSeats, int maxSpeed, int numberOfWeapons) : this(numberOfSeats, maxSpeed, numberOfWeapons, false) { }

        public Beter(int numberOfSeats, int maxSpeed, int numberOfWeapons, bool canSwiim) : base(numberOfSeats, maxSpeed, numberOfWeapons) {
            _canSwimm = canSwiim;
        }

        public bool CanSwimm
        {
            get { return _canSwimm; }
            set { _canSwimm = value; }
        }

        public override void move()
        {
            Console.WriteLine("Beter moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Beter breaking...");
        }

        public override void shoot()
        {
            Console.WriteLine("Beter shooting...");
        }

        public void swiiming()
        {
            if (_canSwimm)
            {
                Console.WriteLine("Beter is swiiming...");
            }
        }
    }
}
