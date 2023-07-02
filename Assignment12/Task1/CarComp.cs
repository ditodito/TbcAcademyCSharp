using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class CarComp : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return (int)(x.MaxSpeed - y.MaxSpeed);
        }
    }
}
