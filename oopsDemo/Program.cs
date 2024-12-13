using System;

namespace oopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Library library = new Library();
            Book book1 = new Book { title = "Drama",author="Raju",ISBN="9377377" };
            Book book2 = new Book { title = "adventure",author="santhosh",ISBN="12" };
            Book book3 = new Book { title = "fiction",author="dinesh",ISBN="34" };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("\ndisplaying library books");
            library.Displaybooks();

            Console.WriteLine("\nborrowing the book");
            book1.Borrow();

           
        }
       
    }
}
