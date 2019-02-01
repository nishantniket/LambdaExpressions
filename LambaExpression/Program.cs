using System;

namespace LambaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression

            // () => ...
            // x => ...
            // (x,y,z) => ...
            var bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();
            var cheapBooks = books.FindAll(book => book.Price > 10);
            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title);
            }
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));
        }

        static bool IsBookCheaperThan10(Book book)
        {
            return book.Price < 10;
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
