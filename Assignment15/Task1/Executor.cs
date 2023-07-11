using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Executor
    {

        public static object GetObject(String className)
        {
            Type type = GetClassType(className);
            
            if (type == null)
            {
                throw new ArgumentException($"Class with name {className} not found");
            }

            ConstructorInfo ci = GetSelectedConstructor(type.GetConstructors());
            return ci.Invoke(GetConstructorParams(ci));
        }

        private static ConstructorInfo GetSelectedConstructor(ConstructorInfo[] constructors)
        {
            string st = "Choose constructor type to create object:\n";
            for (int i = 0; i < constructors.Length; i++) {
                st += i + ") constructor with " + constructors[i].GetParameters().Length + " parameters";
                if (i < constructors.Length - 1)
                    st += "\n";
            }
            
            Console.WriteLine(st);
            
            int constructorIndex = -1;
            while (!int.TryParse(Console.ReadLine(), out constructorIndex) || constructorIndex < 0 || constructorIndex > constructors.Length - 1) {
                Console.Write("You choose wrong constructor, please try again: ");
            }

            return constructors[constructorIndex];
        }

        public static List<string> GetClassNames()
        {
            List<string> result = new List<String>();

            Assembly currentAssembly = Assembly.GetExecutingAssembly();

            foreach (Type type in currentAssembly.GetTypes())
            {
                if (typeof(IVehicle).IsAssignableFrom(type) && !type.IsInterface)
                {
                    result.Add(type.Name);
                }
            }

            return result;
        }

        public static bool IsClassExist(string className)
        {
            return GetClassNames().Contains(className);
        }
        
        public static List<string> GetMethodNames(string className)
        {
            List<string> result = new List<String>();

            Type type = GetClassType(className);
            if (type == null) {
                return result;
            }

            foreach (MethodInfo mi in type.GetMethods())
            {
                if (!mi.IsSpecialName) {
                    result.Add(mi.Name);
                }
            }

            return result;
        }

        public static bool IsMethodExist(string className, string methodName)
        {
            return GetMethodNames(className).Contains(methodName);
        }

        public static Type GetClassType(string className)
        {
            if (!IsClassExist(className))
            {
                return null;
            }

            switch (className)
            {
                case "Car":
                    return typeof(Car);
                case "Combat":
                    return typeof(Combat);
                case "Vehicle":
                    return typeof(Vehicle);
                default:
                    return null;
            }
        }

        public static object[] GetMethodParams(string className, string methodName)
        {
            Type type = GetClassType(className);
            if (type == null || !IsMethodExist(className, methodName))
            {
                return new object[] { };
            }

            MethodInfo mi = type.GetMethod(methodName);

            return GetParameters(mi.GetParameters(), false);
        }

        private static object[] GetConstructorParams(ConstructorInfo constructorInfo)
        {
            List<object> result = new List<object>();

            return GetParameters(constructorInfo.GetParameters(), true);
        }

        private static object[] GetParameters(ParameterInfo[] paramsInfo, bool isConstructor)
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
                    Console.Write("Enter '{0}' value for {1} parameter '{2}': ", pi.ParameterType, (isConstructor ? "constructor" : "method"), pi.Name);
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
