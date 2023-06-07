// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter integer number:");
bool isValidNumber = int.TryParse(Console.In.ReadLine(), out int number);

if (!isValidNumber)
{
    Console.WriteLine("Invalid number, please try again!");
}

int counter = 0;
number = Math.Abs(number);

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        counter++;
    }
}

Console.WriteLine("{0} has {1} divider", number, counter);