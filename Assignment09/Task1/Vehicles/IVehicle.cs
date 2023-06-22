using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Vehicles
{
    public interface IVehicle
    {
        int NumberOfSeats { get; }

        int MaxSpeed { get; }
        
        void move();

        void breaking();
    }
}
