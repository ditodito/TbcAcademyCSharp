// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter numbers seperated by space");
string input = Console.ReadLine();
string[] strings = input.Split(" ");
int[] numbers = new int[strings.Length];

for (int i = 0; i < numbers.Length; i++)
{
    if (int.TryParse(strings[i], out int val))
    {
        numbers[i] = val;
    } else
    {
        numbers[i] = 0;
    }
}

//int[] numbers = { 1, 3, -15, 17, 12, -3 };

int counter = 0;
int sum = 0;

foreach(int number in numbers.ToArray())
{
    if (number > 0)
    {
        sum += number;
        counter++;
    }
}

Console.WriteLine("Sum of positive numbers are {0}, avarage is {1}", sum, (double) sum / (double) counter);
