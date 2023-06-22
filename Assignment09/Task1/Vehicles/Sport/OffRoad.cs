using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles.Sport
{
    public class OffRoad : Sport
    {
        public OffRoad() : this(2) { }

        public OffRoad(int numberOfSeats) : this(numberOfSeats, 180) { }

        public OffRoad(int numberOfSeats, int maxSpeed) : base(numberOfSeats, maxSpeed) { }
    }
}
