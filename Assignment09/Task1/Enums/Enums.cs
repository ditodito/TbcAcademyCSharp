using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Enums
{
    public class Enums
    {

        public enum VehicleType 
        {
            Combat = 1,
            Consumer = 2,
            Public = 3,
            Sport = 4
        }

        public enum CombatType
        {
            Tank = 1,
            Beter = 2
        }

        public enum ConsumerType
        {
            Sedan = 1,
            Jeep = 2,
            Motorcycle = 3,
            Bicycle = 4
        }

        public enum PublicType
        {
            Bus = 1,
            Tram = 2
        }

        public enum SportType
        {
            Formula1 = 1,
            Rally = 2,
            Offroad = 3
        }

        public enum FuelType { 
            Oil = 1,
            Dissel = 2,
            Hybrid = 3,
            Electro = 4
        }

        public enum Material
        {
            Iron = 1,
            Alluminium = 2,
            Carbon = 3
        }

    }
}
