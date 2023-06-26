using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IMath<T>
    {
        public T Add(T num1, T num2);

        public T Substract(T num1, T num2);

        public T Multiply(T num1, T num2);
    }
}
