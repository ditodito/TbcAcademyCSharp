// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter integer number:");
bool isValidNumber = int.TryParse(Console.In.ReadLine(), out int number) && number >= 2;

if (!isValidNumber)
{
    Console.WriteLine("Invalid number, please try again!");
    return;
}

bool isSimple = true;

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isSimple = false;
        break;
    }
}

Console.WriteLine("{0} is {1}", number, isSimple ? "simple" : "not simple");



