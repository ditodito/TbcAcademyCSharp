using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Car
    {
        private string _mark;
        private double _weight;
        private double _maxSpeed;

        public Car(string mark, double weight, double maxSpeed)
        {
            _mark = mark;
            _weight = weight <= 0 ? 100 : weight;
            _maxSpeed = maxSpeed <= 0 ? 120 : maxSpeed;
        }

        public string Mark { get { return _mark; } }
        
        public double Weight { get { return _weight; } }
        
        public double MaxSpeed { get { return _maxSpeed; } }

        public override string ToString()
        {
            return _mark + " " + _weight + " " + _maxSpeed;
        }
    }
}
