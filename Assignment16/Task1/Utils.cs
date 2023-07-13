using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Utils
    {
        private static Type type = typeof(Calculator);

        public static List<string> GetCalculatorMethods()
        {
            List<string> result = new List<string>();

            foreach(MethodInfo mi in type.GetMethods())
            {
                result.Add(mi.Name);
            }

            return result;
        }

        public static bool IsMethodExist(string methodName)
        {
            return GetCalculatorMethods().Contains(methodName);
        }

        public static object[] GetMethodParams(string methodName)
        {
            MethodInfo mi = type.GetMethod(methodName);

            return GetParameters(mi.GetParameters());
        }

        private static object[] GetParameters(ParameterInfo[] paramsInfo)
        {
            List<object> result = new List<object>();

            if (paramsInfo.Length == 0)
            {
                return result.ToArray();
            }

            foreach (ParameterInfo pi in paramsInfo)
            {
                bool cont = true;

                while (cont)
                {
                    Console.Write("Enter '{0}' value for method parameter '{1}': ", pi.ParameterType, pi.Name);
                    dynamic value = null;

                    if (typeof(string) == pi.ParameterType)
                    {
                        value = Console.ReadLine();

                        if (!string.IsNullOrEmpty(value))
                        {
                            cont = false;
                        }
                    }
                    else if (typeof(double) == pi.ParameterType)
                    {
                        if (double.TryParse(Console.ReadLine(), out double res))
                        {
                            cont = false;
                            value = res;
                        }
                    }
                    else if (typeof(int) == pi.ParameterType)
                    {
                        if (int.TryParse(Console.ReadLine(), out int res))
                        {
                            cont = false;
                            value = res;
                        }
                    }

                    if (!cont)
                    {
                        result.Add(value);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
