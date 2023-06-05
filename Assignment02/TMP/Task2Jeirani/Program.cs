// See https://aka.ms/new-console-template for more information

// დავალება 2
Console.Out.WriteLine("Enter one of the values: rock, paper, scisoors");
string userChoise = Console.ReadLine().Trim().ToLower();

if (!(userChoise == "rock" || userChoise == "paper" || userChoise == "scisoors"))
{
    Console.WriteLine("You enter wrong value, please try again!");
    return;
}

Random random = new Random();
int randomNumber = random.Next(3);
string compChoice = randomNumber == 0 ? "rock" : (randomNumber == 1 ? "paper" : "scisoors");

switch(userChoise)
{
    case "rock":
        if (compChoice == "scisoors")
        {
            Console.WriteLine("User win, computer choice was " + compChoice);
        }
        else if (compChoice == "paper") {
            Console.WriteLine("Computer win, computer choice was " + compChoice);
        }
        else
        {
            Console.WriteLine("Draw, computer choice was " + compChoice);
        }
        break;
    case "paper":
        if (compChoice == "rock")
        {
            Console.WriteLine("User win, computer choice was " + compChoice);
        }
        else if (compChoice == "scisoors")
        {
            Console.WriteLine("Computer win, computer choice was " + compChoice);
        }
        else
        {
            Console.WriteLine("Draw, computer choice was " + compChoice);
        }
        break;
    case "scisoors":
        if (compChoice == "paper")
        {
            Console.WriteLine("User win, computer choice was " + compChoice);
        }
        else if (compChoice == "rock")
        {
            Console.WriteLine("Computer win, computer choice was " + compChoice);
        }
        else
        {
            Console.WriteLine("Draw, computer choice was " + compChoice);
        }
        break;
    default:
        break;
}
