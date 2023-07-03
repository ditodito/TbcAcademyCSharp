using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Library
    {
        private List<Book> _books = new List<Book>(4);

        public int Capacity { get { return _books.Capacity; } }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("book");
            }

            if (_books.Count + 1 > Capacity)
            {
                throw new IndexOutOfRangeException("Book list is full (Capacity = " + Capacity + "; List size: " + _books.Count + "). You can't add another item!");
            }

            _books.Add(book);
            Console.WriteLine("Book " + book.Title + " added successfully");
        }

        public Book GetBook(string number)
        {
            Book result = _books.Find(book => book.Number.Equals(number));

            BookNotFoundException be = new BookNotFoundException("Book not found");

            be.Data.Add("Book", "Book with number of " + number + " not found");

            return result != null ? result : throw be;
        }
    }
}
