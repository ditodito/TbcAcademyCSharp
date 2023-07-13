// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Task1;

Console.Write("Select method ({0}): ", string.Join(", ", Utils.GetCalculatorMethods()));
string methodName = Console.ReadLine();

while(string.IsNullOrEmpty(methodName) || !Utils.IsMethodExist(methodName))
{
    Console.Write("Your seleced method does'n exist, please try again: ");
    methodName = Console.ReadLine();
}

object[] @params = Utils.GetMethodParams(methodName);
double operationResult = DelecateUtils.Invoke(DelecateUtils.GetDelecate(methodName), @params);

Console.WriteLine("'{0}' operation result for params ({1}) = {2}", methodName, string.Join(", ", @params), operationResult);