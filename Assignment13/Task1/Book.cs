using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Book
    {
        public string Number { get; }
        public string Title { get; }
        public string Author { get; }

        public Book(string number, string title, string author)
        {
            if (String.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException("Number");
            }

            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title");
            }

            if (String.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException("Author");
            }

            Number = number;
            Title = title;
            Author = author;
        }
    }
}
