using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNS
{
    public class Question
    {
        private int _id;
        
        private string _title;
        
        private int _point;

        private List<Answer> _answers;

        public Question(int id, string title, int point, List<Answer> answers)
        {
            _id = id;
            _title = title;
            _point = point;
            _answers = answers;
        }

        public string Title { get { return _title; } }

        public int Point { get { return _point; } }

        public bool IsCorrectAnswer(int selectedAnserId)
        {
            return _answers.Any((answer) => answer.Id == selectedAnserId && answer.IsCorrect);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(_id + ") " + _title + " (Point = " + _point + ")");
            
            foreach(Answer answer in _answers)
            {
                sb.AppendLine();
                sb.Append("\t");
                sb.Append(answer);
            }

            return sb.ToString();
        }
    }
}
