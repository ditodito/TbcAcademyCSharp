using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task1.McDonald
{
    public class McDonald
    {
        private bool _isOpen;

        private Queue<Order> _orders;

        public string Address { get; set; }
        
        public bool IsOpen { get { return _isOpen; } }
        
        public McDonald(string address)
        {
            Address = address;
            _isOpen = true;
            _orders = new Queue<Order>();
        }

        public void StartOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine(order.Name + " (" + order.Price + ")" + " added successfully");
        }

        public void FinishOrder()
        {
            if (_orders.TryDequeue(out Order order))
            {
                Console.WriteLine(order.Name + " (" + order.Price + ")" + " finished successfully");
            }
        }

        public Order GetCurrentOrder()
        {
            if(_orders.TryPeek(out Order order))
            {
                return order;
            }

            return null;
        }

        public void CloseOffice()
        {
            _isOpen = false;
            Clear();
            Console.WriteLine("Offece is closed, all orders are cleared");
        }

        private void Clear()
        {
            _orders.Clear();
        }

        public string GetAllOrder()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(Order order in _orders)
            {
                sb.Append(order + "\n");
            }

            return sb.ToString();
        }

    }
}
