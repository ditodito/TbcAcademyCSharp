using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.School
{
    internal class SchoolClass
    {
        private string _schoolName;
        
        private string _className;

        private SortedList<string, Student> _students;

        public string SchoolName { get { return _schoolName; } }
        
        public string ClassName { get { return _className; } }

        public SortedList<string, Student> Students { get { return _students; } }

        public SchoolClass(string schoolName, string className)
        {
            _schoolName = schoolName;
            _className = className;
            _students = new SortedList<string, Student>(new StudentComp());
        }

        public void Add(string key, Student value)
        {
            if (_students.TryAdd<string, Student>(key, value))
            {
                Console.WriteLine(value.Name + " added to class " + _className);
            }
        }

        public void Remove(string key)
        {
            if (_students.Remove<string, Student>(key, out Student value))
            {
                Console.WriteLine(value.Name + " removed from class " + _className);
            }
        }

        public void Clear()
        {
            _students.Clear();
            Console.WriteLine(_className + " class cleared");
        }

        public int GetTotalStudents()
        {
            return _students.Count;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Student student in Students.Values)
            {
                sb.Append(student);
                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}
