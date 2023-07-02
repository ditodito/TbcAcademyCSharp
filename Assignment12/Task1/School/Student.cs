using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.School
{
    public class Student
    {
        private int _id;

        public int Id { get { return _id; } }

        public string Name { get; set; }
        

        public static int Count = 1;

        public Student(string name) {
            Name = name;
            _id = Count++;
        }

        public override string ToString()
        {
            return "Id: " + _id + "; Name: " + Name;
        }
    }
}
