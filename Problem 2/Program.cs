using System;
using System.Collections.Generic;

namespace Problem_2
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("Life of Pesho", "Petur Ivanov", 200));
            books.Add(new Book("Sherlok Homs", "Arthur Conan", 450));

            foreach(Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("------------------------------------ \n");
            List<GoldenEditionBook> vip_books = new List<GoldenEditionBook>();
            vip_books.Add(new GoldenEditionBook("Life of Pesho", "Petur Ivanov", 200));
            vip_books.Add(new GoldenEditionBook("Pesho", "Ivanov", 450));

            foreach(GoldenEditionBook vip_book in vip_books)
            {
                Console.WriteLine(vip_book.ToString());
            }
            


            Console.ReadLine();
        }
    }
}
