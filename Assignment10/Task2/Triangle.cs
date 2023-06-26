using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle
    {
        private double _area;
        private double _perimeter;

        public double Area() {
            return _area;
        }

        //public 

        public Triangle(double area)
        {
            this._area = area < 0 ? 0 : area;
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return t1.Area() == t2.Area();
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return t1.Area() != t2.Area();
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            return t1.Area() > t2.Area();
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            return t1.Area() < t2.Area();
        }

        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            return new Triangle(t1.Area() + t2.Area());
        }

        public static explicit operator Triangle(double area)
        {
            return new Triangle(area);
        }

    }
}
