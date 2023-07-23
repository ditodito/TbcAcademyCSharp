using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Club
    {
        private static int _clubId = 1;

        private int _id;

        private string _name;

        public Club(string name)
        {
            _id = _clubId++;
            _name = name;
        }

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public List<Player> Players { get; set; }
    }
}
