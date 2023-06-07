// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter integer number:");
bool isValidNumber = int.TryParse(Console.In.ReadLine(), out int number);

if (!isValidNumber)
{
    Console.WriteLine("Invalid number, please try again!");
}

bool isSimple = true;
number = Math.Abs(number);

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isSimple = false;
        break;
    }
}

Console.WriteLine("{0} is {1}", number, isSimple ? "simple" : "not simple");



