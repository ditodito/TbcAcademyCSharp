using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.McDonald
{
    public class Order
    {
        private int _id;
        private string _name;
        private double _price;
        private static int orderId = 1;

        public int Id { get { return _id; } }
        
        public string Name { get { return _name; } }

        public double Price{ get { return _price; } }

        public Order(string name, double price)
        {
            _id = orderId++;
            _name = name;
            _price = price;
        }

        public override string ToString()
        {
            return "Order Id: " + _id + "; Order Name: " + _name + "; Order Price: " + _price;
        }
    }
}
