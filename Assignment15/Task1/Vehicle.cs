using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Vehicle : IVehicle
    {
        protected double _weight;

        public Vehicle(double weight)
        {
            _weight = weight;
        }

        public double Weight {
            get { return _weight; }
            set { _weight = value; }
        }

       /*public virtual void Move()
        {
            Console.Write("Vehicle moving...");
        }*/

        public virtual void Move(double speed)
        {
            Console.Write("Vehicle moving, speed is {0}...", speed);
        }

        public virtual void Stop()
        {
            Console.Write("Vehicle stoping...");
        }
    }
}
