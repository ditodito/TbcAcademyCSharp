using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Storage<T>
    {
        private T _value;

        public T Value { get { return _value; } }

        public void Add(T value)
        {
            _value = value;
        }

        public void Remove()
        {
            _value = default(T);
        }

        public void Update(T value)
        {
            _value = value;
        }
    }
}
