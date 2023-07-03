using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BookNotFoundException : ApplicationException
    {
        public DateTime DateOfException { get; }

        public BookNotFoundException(string name) : base(name) {
            DateOfException = DateTime.Now;
        }
    }
}
