using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Book
    {
        public string Title;
        public string Author;
        public int Year;
        public int PageNumber;

        public override string ToString()
        {
            return "Book: " + Title + "; " + Author + "; " + Year + "; " + PageNumber;
        }
    }


}
