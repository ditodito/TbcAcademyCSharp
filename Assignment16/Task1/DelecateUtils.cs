using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DelecateUtils
    {

        public static double Invoke(Delegate del, object[] @params)
        {
            //return del((double) @params[0], (double) @params[1]);
            return (double) del.Method.Invoke(null, @params);
        }

        public static Delegate GetDelecate(string methodName)
        {
            Delegate del = null;

            switch (methodName)
            {
                case "Add":
                    del = Calculator.Add;
                    break;
                case "Sub":
                    del = Calculator.Sub;
                    break;
                case "Mult":
                    del = Calculator.Mult;
                    break;
                case "Div":
                    del = Calculator.Div;
                    break;
                case "Sqrt":
                    del = Calculator.Sqrt;
                    break;
                case "Pow":
                    del = Calculator.Pow;
                    break;
            }

            return del;
        }

        public delegate double Del1(double num1, double num2);
        public delegate double Del2(double num);
    }
}
