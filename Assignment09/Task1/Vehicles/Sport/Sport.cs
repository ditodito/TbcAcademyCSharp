using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Sport
{
    public abstract class Sport : Vehicle
    {
        public Sport(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) { }

        public override void move()
        {
            Console.WriteLine("Sport car moving...");
        }

        public override void breaking()
        {
            Console.WriteLine("Sport car breaking...");
        }
    }
}
