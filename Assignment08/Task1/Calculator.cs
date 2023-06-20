using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Calculator
    {
        
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Pow(double num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            double result = num;

            for(int i = 1; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }

        public static double Sqrt(double num)
        {
            if (num < 0)
            {
                return double.NaN;
            }

            double result = 0;
            int d = 1;

            while (num > 0)
            {
                num -= d;
                result++;
                d += 2;

            }

            return num == 0 ? result : double.NaN;
        }

    }
}
