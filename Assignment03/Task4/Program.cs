// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number:");

if (!int.TryParse(Console.ReadLine(), out int number)) {
    Console.WriteLine("Invalid number, please try again");
    return;
}

for (int i = 0; i < number; i++)
{
    string res = "";
    //for (int j = 0; j < i * 2 + 1; j++) {
    for (int j = 0; j < number + (number - 1); j++) {
        if (j < number - (i + 1) || j >= number + i)
        {
            res += " ";
        }
        else {
            res += "*";
        }
    }

    Console.WriteLine(res);
}