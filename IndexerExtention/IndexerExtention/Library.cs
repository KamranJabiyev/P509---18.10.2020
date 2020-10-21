using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention
{
    class Library
    {
        public string Name { get; set; }
        private Book[] books;

        public Library(string name)
        {
            Name = name;
            books = new Book[100];
        }

        public Book this[int i]
        {
            get
            {
                try
                {
                    if (books[i] == null)
                    {
                        return books[0];
                    }
                    else
                    {
                        return books[i];
                    }
                }
                catch (Exception)
                {

                    return books[0];
                }
            }
            set
            {
                if (i < books.Length)
                {
                    books[i] = value;
                    return;
                }
                Console.WriteLine($"{i}-ci index movcud deyil");
            }
        }

        //public void AddBook(Book book)
        //{
        //    Array.Resize(ref books, books.Length + 1);
        //    books[books.Length - 1] = book;
        //}
    }
}
