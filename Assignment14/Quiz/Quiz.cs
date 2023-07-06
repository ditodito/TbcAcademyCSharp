using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuizNS
{
    public class Quiz : IDisposable
    {
        const string fpq = @"C:\Apps\C#\Assignment14\Quiz\questions.txt";
        const string fpa = @"C:\Apps\C#\Assignment14\Quiz\answers.txt";
        const string fpqn = @"C:\Apps\C#\Assignment14\Quiz\quizname.txt";
        private StreamWriter sw;
        private StreamReader sr;
         
        public Quiz() { }

        public int QuantityOfQuestions { get { return GetQuantityOfQuestions(); } }

        public string QuizName { get { return GetQuizName(); } }
        
        public string PersonName { get; set; }

        public void SetQuizName()
        {
            Console.Write("Enter quiz name: ");
           
            string quizName = Console.ReadLine();
            
            if (string.IsNullOrEmpty(quizName))
            {
                throw new ArgumentNullException(nameof(quizName));
            }

            using (sw = new StreamWriter(fpqn))
            {
                sw.WriteLine(quizName);
            }
        }

        public void SetPersonName()
        {
            Console.Write("Enter person name: ");

            string personName = Console.ReadLine();

            if (string.IsNullOrEmpty(personName))
            {
                throw new ArgumentNullException(nameof(personName));
            }

            PersonName = personName;
        }

        public void FillQuestions()
        {
            string exitKey = "y";
            List<string> questionsList = new List<string>();
            List<string> answersList = new List<string>();
            int questionNumber = GetQuantityOfQuestions() + 1;

            while (exitKey.Equals("y"))
            {
                Console.Write("Question {0}: ", questionNumber);
                string question = Console.ReadLine();

                if (string.IsNullOrEmpty(question))
                {
                    throw new ArgumentNullException("Question " + questionNumber);
                }

                Console.Write("Point for question {0}: ", questionNumber);

                if (!int.TryParse(Console.ReadLine(), out int point) || point < 0)
                {
                    throw new ArgumentNullException("Point " + questionNumber);
                }

                /*using(sw = File.AppendText(fpq))
                {
                    sw.WriteLine((questionNumber++) + ";" + "" + question + ";" + value);
                }*/

                questionsList.Add(questionNumber + ";" + "" + question + ";" + point);
                answersList.AddRange(FillAnswers(questionNumber));
                questionNumber++;

                Console.Write("Add another question (Y/N): ");

                exitKey = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(exitKey))
                {
                    exitKey = exitKey.ToLower();
                }
            }

            Console.Write("Save changes (Y/N): ");
            string save = Console.ReadLine();
            if (!String.IsNullOrEmpty(save) && save.ToLower().Equals("y"))
            {
                File.AppendAllLines(fpq, questionsList);
                File.AppendAllLines(fpa, answersList);
                Console.WriteLine("Quiz saved successfully!");
            }
            else {
                Console.WriteLine("Quiz not saved!");
            }
        }

        public void ClearQuiz()
        {
            Console.WriteLine("Quiz '{0}' are cleared!", QuizName);
            File.WriteAllText(fpq, string.Empty);
            File.WriteAllText(fpa, string.Empty);
            File.WriteAllText(fpqn, string.Empty);
            /*sw = new StreamWriter(fpq);
            sw.Write(string.Empty);
            sw = new StreamWriter(fpa);
            sw.Write(string.Empty);*/
        }

        public void StartQuiz()
        {
            if (QuantityOfQuestions == 0)
            {
                Console.WriteLine("There is no quiz to start, please construct quiz at first");
                return;
            }

            Console.WriteLine("Start quiz '{0}'", QuizName);
            SetPersonName();

            int totalPoint = 0;

            foreach (Question question in GetQuestions())
            {
                Console.WriteLine(question);
                Console.Write("Your answer: ");

                if (!int.TryParse(Console.ReadLine(), out int selectedAnserId))
                {
                    throw new ArgumentNullException("Answer for " + question.Title);
                }

                if (question.IsCorrectAnswer(selectedAnserId))
                {
                    totalPoint += question.Point;
                }
            }

            Console.WriteLine("{0}, your total point for quiz '{1}' is {2}", PersonName, QuizName, totalPoint);
        }

        private static List<string> FillAnswers(int questionId)
        {
            string exitKey = "y";
            List<string> answersList = new List<string>();
            int answerNumber = 1;

            while (exitKey.Equals("y"))
            {
                Console.Write("Answer {0}: ", answerNumber);
                string answer = Console.ReadLine();

                if (string.IsNullOrEmpty(answer))
                {
                    throw new ArgumentNullException("Answer " + answerNumber);
                }

                Console.Write("Answer {0} is correct: (1 is True, other value will considered as false): ", answerNumber);

                string isCorrect = Console.ReadLine();

                /*using (sw = File.AppendText(fpa))
                {
                    sw.WriteLine((answerNumber++) + ";" + "" + answer + ";" + (isCorrect.Equals("1") ? 1 : 0));
                }*/

                answersList.Add((answerNumber++) + ";" + "" + answer + ";" + (isCorrect.Equals("1") ? 1 : 0) + ";" + questionId);

                Console.Write("Add another answer (Y/N): ");

                exitKey = Console.ReadLine();
                if (!string.IsNullOrEmpty(exitKey))
                {
                    exitKey = exitKey.ToLower();
                }
            }

            return answersList;
        }

        private static int GetQuantityOfQuestions()
        {
            return File.ReadAllLines(fpq).Length;
        }

        private string GetQuizName()
        {
            string resutl = String.Empty;

            using (sr = new StreamReader(fpqn))
            {
                resutl = sr.ReadLine();
            }

            return resutl;
        }

        private static IEnumerable<Question> GetQuestions()
        {
            foreach (string line in File.ReadLines(fpq))
            {
                string[] q = line.Split(";");
                int id = int.Parse(q[0]);
                string title = q[1];
                int point = int.Parse(q[2]);
                List<Answer> answers = GetAnswers(id);

                yield return new Question(id, title, point, answers);
            }
        }

        private static List<Answer> GetAnswers(int questionId)
        {
            List<Answer> result = new List<Answer>();

            foreach (string line in File.ReadAllLines(fpa))
            {
                string[] a = line.Split(";");
                int id = int.Parse(a[0]);
                string title = a[1];
                bool isCorrect = a[2].Equals("1");
                int qId = int.Parse(a[3]);

                if (questionId == qId)
                {
                    result.Add(new Answer(id, title, isCorrect));
                }
            }

            return result;
        }

        public void Dispose()
        {
            //Console.WriteLine("Dispose");
            if (sw != null)
            {
                sw.Dispose();
            }

            if (sr != null)
            {
                sr.Dispose();
            }

            //sw.Dispose();
            //fs.Dispose();
            //sw.Flush();
            //sw.Close();
        }
    }
}
