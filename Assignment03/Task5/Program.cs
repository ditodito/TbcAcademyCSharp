// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

void mainProgram()
{
    // Min value block
    Console.WriteLine("Enter number min number:");

    bool isValidMinNumber = false;
    int minNumber = 0;
    
    while (!isValidMinNumber)
    {
        isValidMinNumber = int.TryParse(Console.ReadLine(), out int val);
        
        if (!isValidMinNumber)
        {
            Console.WriteLine("Invalid min number, enter valid number:");
        }
        else {
            minNumber = val;

        }
    }

    // Max value block
    Console.WriteLine("Enter number max number:");

    bool isValidMaxNumber = false;
    int maxNumber = 0;

    while (!isValidMaxNumber)
    {
        isValidMaxNumber = int.TryParse(Console.ReadLine(), out int val);
        
        if (!isValidMaxNumber)
        {
            Console.WriteLine("Invalid max number, enter valid number:");
        }
        else {
            maxNumber = val;
        }
    }

    // Execute program
    Random random = new Random();
    int randomNumbr = random.Next(minNumber, maxNumber);
    //Console.WriteLine(randomNumbr);

    int tryNumber = 0;
    bool guessed = false;

    Console.Out.WriteLine("Enter number between {0} and {1} to guess:", minNumber, maxNumber);

    while (!guessed)
    {
        if (!int.TryParse(Console.ReadLine(), out int guessNumber))
        {
            Console.WriteLine("Invalid guess number, enter valid number:");
            continue;
        }

        if (randomNumbr == guessNumber)
        {
            guessed = true;
        }
        else
        {
            Console.WriteLine("You couldn't guess, try again:");
        }

        tryNumber++;
    }

    Console.WriteLine("You used {0} try to guess number.", tryNumber);

    // Try again block
    Console.WriteLine("Try again: Yes, No", tryNumber);
    
    string cont = Console.ReadLine().ToLower();
    
    if (cont == "yes")
    {
        mainProgram();
    }
    else {
        Environment.Exit(0);
    }
}

mainProgram();