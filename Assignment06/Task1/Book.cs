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
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int PageNumber { get; set; }

        public override string ToString()
        {
            return "Book: " + Title + "; " + Author + "; " + Year + "; " + PageNumber;
        }
    }


}
