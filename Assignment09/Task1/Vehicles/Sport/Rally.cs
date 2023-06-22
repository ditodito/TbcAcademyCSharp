using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Sport
{
    public class Rally : Sport
    {
        public Rally() : this(2) { }

        public Rally(int numberOfSeats) : this(numberOfSeats, 325) { }

        public Rally(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) { }

        public override void move()
        {
            Console.WriteLine("Rally car moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Rally car breaking...");
        }
    }
}
