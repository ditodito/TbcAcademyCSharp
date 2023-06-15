// See https://aka.ms/new-console-template for more information


using LibrarySystem;
using System;

Console.WriteLine("Library Program!");

Library lib = new Library();
Console.WriteLine("Length of books in library {0}", lib.Count);

Book b1 = new Book() {
    Title = "Book 1",
    Author = "Author 1",
    Year = 2009,
    PageNumber = 568
};

Book b2 = new Book()
{
    Title = "Book 2",
    Author = "Author 2",
    Year = 2010,
    PageNumber = 720
};

Book b3 = new Book()
{
    Title = "Book 3",
    Author = "Author 3",
    Year = 2011,
    PageNumber = 1105
};

lib.AddBook(b1);
Console.WriteLine("Length of books in library {0}", lib.Count);

lib.AddBook(b2);
Console.WriteLine("Length of books in library {0}", lib.Count);

lib.AddBook(b3);
Console.WriteLine("Length of books in library {0}", lib.Count);

lib.RemoveBook(1);
//lib.RemoveBook(1);
//lib[11] = b1;
try
{
    Book ib = lib[1];
    Console.WriteLine(ib);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

Book fb = lib.FindBook("author 3");
if (fb != null)
{
    Console.WriteLine(fb);
}



//lib.RemoveBook(b2);
//lib.RemoveBook(2);
//Console.WriteLine(lib.Count);
