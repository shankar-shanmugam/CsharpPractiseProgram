using System;
using System.Collections.Generic;
using System.Text;

namespace oopsDemo
{
    internal class Library
    {
        private List<Book> books =new List<Book>();

        public void AddBook(Book book)
        {
            if(books==null) books = new List<Book>();
            books.Add(book);
            Console.WriteLine($"{book.title} book is added");
        }

        public void Displaybooks()
        {
            if (books.Count == 0) {

                Console.WriteLine("No books to Display");
                return;
            }
            else
            {
                foreach (Book book in books)
                {
                    book.DisplayInfo();
                }

            }
        }

    }
}
