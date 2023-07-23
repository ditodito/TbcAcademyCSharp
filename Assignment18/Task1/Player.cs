using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Player
    {
        private static int _playerId = 1;

        private int _id;

        private string _name;

        private Position _position;

        private Country _nationality;

        private int _clubId;

        private int[] _goals;

        public Player(string name, Position position, Country nationality, int clubId, int[] goals)
        {
            _id = _playerId++;
            _name = name;
            _position = position;
            _nationality = nationality;
            _clubId = clubId;
            _goals = goals;
        }

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public Position Position { get { return _position; } }

        public Country Nationality { get { return _nationality; } }

        public int ClubId { get { return _clubId; } }

        public int[] Goals { get { return _goals; } }

        public override string ToString()
        {
            return "Id = " + _id + "; Name = " + _name + "; Position = " + _position + "; Nationality = " + _nationality + "; ClubId = " + _clubId + "; Goals = " + string.Join(", ", Goals);
        }
    }
}
