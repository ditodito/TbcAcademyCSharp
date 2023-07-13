using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2.FindDelegateUtils;

namespace Task2
{
    public class Contact
    {
        private List<Person> _persons;

        public Contact() {
            _persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

        public List<Person> FindPerson(FindDelegate del, string searchKey)
        {
            List<Person> list = new List<Person>();

            foreach(Person p in _persons)
            {
                if (del(p, searchKey))
                {
                    list.Add(p);
                }
            }

            return list;
        }
    }
}
