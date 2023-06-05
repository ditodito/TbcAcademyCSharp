// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// დავალება 1
Console.WriteLine("Enter TMP");
bool validTmp = Double.TryParse(Console.ReadLine(), out double tmp);

if (!validTmp)
{
    Console.Out.WriteLine("You enter invalid tmp number");
    return;
}

if (tmp < 0)
{
    Console.Out.WriteLine("Freeze");
}
else if (tmp >= 0 && tmp <= 30)
{
    Console.WriteLine("Good Wather");
} else
{
    Console.WriteLine("Hot");
}