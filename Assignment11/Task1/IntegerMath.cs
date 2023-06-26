using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class IntegerMath : IMath<int>
    {
        public int Add(int num1, int num2) {
            return num1 + num2;
        }

        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
