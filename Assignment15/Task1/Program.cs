// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using Task1;

try
{
    Console.Write("Type class name ({0}) to create instance of this class: ", string.Join(", ", Executor.GetClassNames()));
    string className = Console.ReadLine();

    while (string.IsNullOrEmpty(className) || !Executor.IsClassExist(className))
    {
        Console.Write("You type wrong class name, please try again: ");
        className = Console.ReadLine();
    }

    var obj = Executor.GetObject(className);

    Console.Write("Type method name ({0}) to execute: ", string.Join(", ", Executor.GetMethodNames(className)));
    string methodName = Console.ReadLine();

    while (string.IsNullOrEmpty(methodName) || !Executor.IsMethodExist(className, methodName))
    {
        Console.Write("You type wrong method name, please try again: ");
        methodName = Console.ReadLine();
    }

    Type type = Executor.GetClassType(className);
    MethodInfo mi = type.GetMethod(methodName);
    object[] @params = Executor.GetMethodParams(className, methodName);

    if (mi.ReturnType.Name != "Void")
    {
        object methodValue = mi.Invoke(obj, @params);
        Console.WriteLine("{0} return this value {1}", methodName, methodValue);
    }
    else
    {
        mi.Invoke(obj, @params);
    }
} 
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}