// See https://aka.ms/new-console-template for more information
using QuizNS;

Console.WriteLine("Select operation: (1 - Construct Quiz; 2 - Start Quiz)");

if (!int.TryParse(Console.ReadLine(), out int operation) || !(operation == 1 || operation == 2)) {
    Console.WriteLine("Invalid operation type 1 or 2");
    return;
}

try
{
    using (Quiz q = new Quiz())
    {
        if (operation == 1)
        {
            if (q.QuantityOfQuestions > 0)
            {
                Console.WriteLine("Select operation: (1 - Clear Quiz; 2 - Add questions to current quiz)");

                if (!int.TryParse(Console.ReadLine(), out int subOperation) || !(subOperation == 1 || subOperation == 2))
                {
                    Console.WriteLine("Invalid operation type 1 or 2");
                    return;
                }

                if (subOperation == 1)
                {
                    q.ClearQuiz();
                    q.SetQuizName();
                    q.FillQuestions();
                }
                else if (subOperation == 2)
                {
                    q.FillQuestions();
                }
            }
            else
            {
                q.SetQuizName();
                q.FillQuestions();
            }
        }
        else if (operation == 2)
        {
            q.StartQuiz();
        }
    }
} 
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}


