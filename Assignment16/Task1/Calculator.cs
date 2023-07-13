using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        public static double Pow(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
