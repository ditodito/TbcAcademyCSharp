using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class PlayerComparer : IEqualityComparer<Player>
    {
        public bool Equals(Player? x, Player? y)
        {
            return x.Position == Position.GoalKipper || y.Position == Position.Forward;
        }

        public int GetHashCode([DisallowNull] Player obj)
        {
            return 1;
        }
    }
}
