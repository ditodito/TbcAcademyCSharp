using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Sport
{
    public class Formula1 : Sport
    {
        public Formula1() : this(1) { }

        public Formula1(int numberOfSeats) : this(numberOfSeats, 555) { }

        public Formula1(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) { }

        public override void move()
        {
            Console.WriteLine("Formula car moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Formula car breaking...");
        }

    }
}
