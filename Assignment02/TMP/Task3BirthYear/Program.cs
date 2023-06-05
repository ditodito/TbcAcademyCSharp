// See https://aka.ms/new-console-template for more information

// დავალება 3
Console.WriteLine("Enter birth year:");
bool isValidBirthYear = Int32.TryParse(Console.ReadLine(), out int birthYear);
if (!isValidBirthYear)
{
    Console.Out.WriteLine("Invalid birth year, please try again");
    return;
}

string result;

switch (birthYear % 12)
{
    case 0:
        result = "Monckey";
        break;
    case 1:
        result = "Rooster";
        break;
    case 2:
        result = "Dog";
        break;
    case 3:
        result = "Pig";
        break;
    case 4:
        result = "Rat";
        break;
    case 5:
        result = "Ox";
        break;
    case 6:
        result = "Tiger";
        break;
    case 7:
        result = "Rabbit";
        break;
    case 8:
        result = "Dragon";
        break;
    case 9:
        result = "Snake";
        break;
    case 10:
        result = "Horse";
        break;
    case 11:
        result = "Goat";
        break;
    default:
        result = "Unknown";
        break;
}

Console.WriteLine("Birth year is in {0}", result);
