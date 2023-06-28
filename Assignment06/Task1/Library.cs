using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Library
    {
        private List<Book> _books = new List<Book>();

        public Book this[int index] { 
            get {
                if (index >= _books.Count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index number (" + index + ") must be (>=0 and < " + _books.Count + ")");
                }

                return _books[index];
            }

            set
            {
                if (index <= _books.Count && index >= 0)
                {
                    _books[index] = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return _books.Count;
            }
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public void RemoveBook(int index)
        {
            if (index < _books.Count && index >= 0)
            {
                _books.RemoveAt(index);
            }
        }

        public Book FindBook(string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                return default;
            }

            return _books.Find(book => String.Equals(book.Title, search, StringComparison.OrdinalIgnoreCase)
                || String.Equals(book.Author, search, StringComparison.OrdinalIgnoreCase));
        }
    }
}
