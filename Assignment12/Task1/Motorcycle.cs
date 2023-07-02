using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Motorcycle : Car
    {
        public string Type { get; set; }

        public Motorcycle(string mark, double weight, double maxSpeed) : this(mark, weight, maxSpeed, "Sport") { }

        public Motorcycle(string mark, double weight, double maxSpeed, string type) : base(mark, weight, maxSpeed) {
            Type = type;
        }

    }
}
