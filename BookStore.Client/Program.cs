using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new BookstoreEntities3();
            var books = dbContext.books;
            foreach (var book in books)
            {
                Console.WriteLine(book.report());
            }
        }
    }
}
