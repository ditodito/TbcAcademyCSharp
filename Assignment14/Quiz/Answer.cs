using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNS
{
    public class Answer
    {
        private int _id;

        private string _title;

        private bool _isCorrect;

        public Answer(int id, string title, bool isCorrect)
        {
            _id = id;
            _title = title;
            _isCorrect = isCorrect;
        }

        public int Id { get { return _id; } }
        public bool IsCorrect { get { return _isCorrect; } }

        public override string ToString()
        {
            return _id + ") " + _title;
        }
    }
}
