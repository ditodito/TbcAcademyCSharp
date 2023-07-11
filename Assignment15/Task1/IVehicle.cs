using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IVehicle
    {

        public double Weight { get; set; }

        /*public void Move();*/

        public void Move(double speed);

        public void Stop();
    }
}
