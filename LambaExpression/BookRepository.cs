using System;
using System.Collections.Generic;
using System.Text;

namespace LambaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{ Title = "Test1", Price = 7},
                new Book{ Title = "Test2", Price = 10},
                new Book{ Title = "Test3", Price = 9},
                new Book{ Title = "Test4", Price = 19},
                new Book{ Title = "Test5", Price = 4},
            };
        }
    }
}
