using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Enums
{
    public static class EnumsHelper
    {
        public static string GetEnumAsString<T>()
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("Not enumeration type");
            }

            StringBuilder sb = new StringBuilder();

            foreach (int i in Enum.GetValues(typeof(T)))
            {
                sb.Append($"{i} - " + Enum.GetName(typeof(T), i) + "; ");
            }

            return sb.ToString();
        }

        public static string GetEnumAsString(string enumName)
        {

            switch (enumName.ToLower())
            {
                case "vehicleType":
                    return GetEnumAsString<Enums.VehicleType>();
                case "combat":
                    return GetEnumAsString<Enums.CombatType>();
                case "consumer":
                    return GetEnumAsString<Enums.ConsumerType>();
                case "public":
                    return GetEnumAsString<Enums.PublicType>();
                case "sport":
                    return GetEnumAsString<Enums.SportType>();
            }

            return "";

        }

        public static bool IsDefined<T>(int value)
        {
            return Enum.IsDefined(typeof(T), value);
        }

        public static dynamic IsDefined(string enumName, int value)
        {

            switch (enumName.ToLower())
            {
                case "vehicleType":
                    return IsDefined<Enums.VehicleType>(value);
                case "combat":
                    return IsDefined<Enums.CombatType>(value);
                case "consumer":
                    return IsDefined<Enums.ConsumerType>(value);
                case "public":
                    return IsDefined<Enums.PublicType>(value);
                case "sport":
                    return IsDefined<Enums.SportType>(value);
            }

            return false;

        }


        public static T GetEnumValue<T>(int i)
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("Not enumeration type");
            }

            T[] enums = (T[])Enum.GetValues(typeof(T));

            T val = default;// enums[0];

            foreach (T e in Enum.GetValues(typeof(T)))
            {
                if (Convert.ToInt32(e) == i)
                {
                    val = e;
                    break;
                }
            }

            return val;
        }

        public static dynamic GetEnumValue(string enumName, int value)
        {
            //string name = Enum.GetName(typeof(Enums.VehicleType), enumValue);

            switch (enumName.ToLower())
            {
                case "vehicleType":
                    return GetEnumValue<Enums.VehicleType>(value);
                case "combat":
                    return GetEnumValue<Enums.CombatType>(value); 
                case "consumer":
                    return GetEnumValue<Enums.ConsumerType>(value);
                case "public":
                    return GetEnumValue<Enums.PublicType>(value);
                case "sport":
                    return GetEnumValue<Enums.SportType>(value);
            }

            return null;
        }




        public static string GetEnumName<T>(int value)
        {
            return Enum.GetName(typeof(T), value);
        }

        public static dynamic GetEnumName(string enumName, int value)
        {
            
            switch (enumName.ToLower())
            {
                case "vehicleType":
                    return GetEnumName<Enums.VehicleType>(value);
                case "combat":
                    return GetEnumName<Enums.CombatType>(value);
                case "consumer":
                    return GetEnumName<Enums.ConsumerType>(value);
                case "public":
                    return GetEnumName<Enums.PublicType>(value);
                case "sport":
                    return GetEnumName<Enums.SportType>(value);
            }

            return "";

        }

    }
}
