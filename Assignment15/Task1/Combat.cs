using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Combat : Vehicle
    {
        private int _numberOfWeapons;

        public Combat(double weight) : this(0, weight) { }

        public Combat(int numberOfWeapons, double weight) : base(weight) {
            _numberOfWeapons = (numberOfWeapons <= 0) ? 1 : numberOfWeapons;
        }

        public int NumberOfWeaposn { get { return _numberOfWeapons; } }

        public void Shoot()
        {
            Console.WriteLine("Combat car shooting...");
        }

        public void ActivateNightMode()
        {
            Console.WriteLine("Combat car activating night mode...");
        }

        public void DeactivateNightMode()
        {
            Console.WriteLine("Combat car deactivating night mode...");
        }

        public int GetNumberOfWeapons()
        {
            return _numberOfWeapons;
        }
    }
}
