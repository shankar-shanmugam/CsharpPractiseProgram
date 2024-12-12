using System;
using System.Collections.Generic;
using System.Text;

namespace oopsDemo
{
    internal class Book : Items,IBorrowable,IReturnable
    {
        public string author {  get; set; }
        public string isbn;
        public string ISBN
        {
            get => isbn;
            set => isbn = value;  
        }
        public Boolean isBorrowed { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title'{this.title}',author '{this.author}',isbn '{this.isbn}'");
        }

        public void Borrow()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine("book is borrowed");
            }
            else
            {
                Console.WriteLine("book is borrowed already");
            }

        }

        public void Return()
        {
           if(isBorrowed)
            {
                Console.WriteLine("book is returned");
                isBorrowed= false;
            }
            else
            {
            Console.WriteLine("book is not borrowed");
            }

        }
    }
}
