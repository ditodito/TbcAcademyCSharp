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
                    //return _books.Last();
                    throw new IndexOutOfRangeException("Invalid index number (" + index + ") must be (>=0 and < " + _books.Count + ")");
                }

                return _books[index];
            }

            set
            {
                if (index <= _books.Count)
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
            if (index < _books.Count)
            {
                _books.RemoveAt(index);
            }
        }

        public Book FindBook(string search)
        {
            string searchKey = search.ToLower();
            return _books.Find(book => book.Title.ToLower().Equals(searchKey) || book.Author.ToLower().Equals(searchKey));
        }
    }
}
