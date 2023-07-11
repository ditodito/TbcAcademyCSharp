using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Car : Vehicle
    {
        private string _mark;
        private string _model;
        private string _type;

        public Car(string mark, string model, double weight) : this(mark, model, weight, "unknown") {
            _mark = mark;
            _model = model;
        }

        public Car(string mark, string model, double weight, string type) : base(weight)
        {
            _mark = mark;
            _model = model;
            _type = type;
        }

        public string Mark { get { return _mark; } }

        public string Model { get { return _model; } }

        public string Type { get { return _type; } }

        /*public override void Move()
        {
            Console.Write("Car {0} {1} moving...", _mark, _model);
        }*/

        public override void Move(double speed)
        {
            Console.Write("Car {0} {1} moving, speed is {2}...", _mark, _model, speed);
        }

        public override void Stop()
        {
            Console.Write("Car {0} {1} stoping...", _mark, _model);
        }

        public void OpenDoor()
        {
            Console.Write("Car {0} {1} door opening...", _mark, _model);
        }

        public void CloseDoor()
        {
            Console.Write("Car {0} {1} door closing...", _mark, _model);
        }

        public double GetWeight()
        {
            return _weight;
        }
    }
}
