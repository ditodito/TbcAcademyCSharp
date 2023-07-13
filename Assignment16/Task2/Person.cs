using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Person
    {
        private string _name;
        private string _surName;
        private int _age;

        public Person(string name, string surName, int age)
        {
            _name = name;
            _surName = surName;
            _age = age;
        }

        public string Name { get { return _name; } }

        public string SurName { get { return _surName; } }
        
        public int Age { get { return _age; } }
    }
}
