// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter integer number:");
bool isValidNumber = int.TryParse(Console.In.ReadLine(), out int number);

if (!isValidNumber)
{
    Console.WriteLine("Invalid number, please try again!");
    return;
}

if (number == 0) {
    Console.WriteLine("0 has infinite divider");
    return;
}

int counter = 0;

for (int i = 1; i <= Math.Abs(number); i++)
{
    if (number % i == 0)
    {
        counter++;
    }
}

if (number < 0) {
    counter *= 2;
}

Console.WriteLine("{0} has {1} divider", number, counter);