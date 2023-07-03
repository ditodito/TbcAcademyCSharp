// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Task1;

Console.WriteLine("Hello, World!");

try
{
    Book b1 = new Book("N1", "Title 1", "Author 1");
    Book b2 = new Book("N2", "Title 2", "Author 2");
    Book b3 = new Book("N3", "Title 3", "Author 3");
    Book b4 = new Book("N4", "Title 4", "Author 4");
    Book b5 = new Book("N4", "Title 5", "Author 5");
    Book b6 = new Book("N4", "Title 6", "Author 6");

    Library lb = new Library();
    lb.AddBook(b1);
    lb.AddBook(b2);
    lb.AddBook(b3);
    lb.AddBook(b4);
    //lb.AddBook(b5);
    //lb.AddBook(b6);

    Book sb = lb.GetBook("Title 2");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ParamName);
}
catch (IndexOutOfRangeException ex) {
    Console.WriteLine(ex.Message);
} 
catch (BookNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
finally
{
    Console.WriteLine("Program finished!");
}