// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter array size:");

int arraySize;
while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
{
    Console.WriteLine("Invalid number, try again:");
}

char[] charsArray = getArray(arraySize);

Console.WriteLine("Enter char to find in array:");

char ch;
while (!char.TryParse(Console.ReadLine(), out ch))
{
    Console.WriteLine("Invalid char, try again:");
}

int numberOfChars = countCharInArray(charsArray, ch);
printCharsInArray(numberOfChars, ch);

char[] getArray(int arraySize)
{
    char[] result = new char[arraySize];

    for (int i = 0; i < arraySize; i++) {
        Console.WriteLine("Enter {0} element:", i + 1);

        while (!char.TryParse(Console.ReadLine(), out result[i]))
        {
            Console.WriteLine("Invalid char, try again:");
        }

    }

    return result;
}

int countCharInArray(char[] chars, char ch) {
    int result = 0;

    foreach(char c in chars)
    {
        if (c == ch) {
            result++;
        }
    }

    return result;
}

void printCharsInArray(int countOfChars, char ch)
{
    Console.WriteLine("Symbol '{0}' entered {1} times", ch, countOfChars);
}