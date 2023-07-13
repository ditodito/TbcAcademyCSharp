using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FindDelegateUtils
    {
        public static Dictionary<string, FindDelegate> delegates = new Dictionary<string, FindDelegate>()
                {
                    {  "1", FindByName},
                    {  "2", FindBySurName },
                    {  "3", FindByFullName },
                    {  "4", FindByAge }

                };

        private static bool FindByName(Person person, string searchKey)
        {
            //return person.Name.Equals(searchKey, StringComparison.OrdinalIgnoreCase);
            return person.Name.Contains(searchKey, StringComparison.OrdinalIgnoreCase);
        }

        private static bool FindBySurName(Person person, string searchKey)
        {
            //return person.SurName.Equals("Messi", StringComparison.OrdinalIgnoreCase);
            return person.SurName.Contains(searchKey, StringComparison.OrdinalIgnoreCase);
        }

        private static bool FindByFullName(Person person, string searchKey)
        {
            //return person.SurName.Equals("Messi", StringComparison.OrdinalIgnoreCase);
            return person.Name.Contains(searchKey, StringComparison.OrdinalIgnoreCase) |
                person.SurName.Contains(searchKey, StringComparison.OrdinalIgnoreCase);
        }

        private static bool FindByAge(Person person, string searchKey)
        {
            string[] range = searchKey.Split("-");
            if (range.Length != 2)
            {
                throw new ArgumentException("Invalid range format, format must have 'num1-num2' pattern");
            }

            if (!int.TryParse(range[0], out int value) || !int.TryParse(range[1], out int value2))
            {
                throw new ArgumentException("One of the range number isn't integer type");
            }

            if (value > value2)
            {
                throw new ArgumentException($"Invalid rage first value {value} is grater then second value {value2}");
            }

            return person.Age >= value && person.Age <= value2;
        }

        public static FindDelegate GetDelegate(string key)
        {
            KeyValuePair<string, FindDelegate> kvp = delegates.FirstOrDefault(x => x.Key.Equals(key));
            return kvp.Value;
        }

        public delegate bool FindDelegate(Person person, string searchKey);
    }
}
