using System;
using System.Globalization;
using System.Threading;

namespace LibraryManagment
{
    class Menu
    {
        public void Show()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-Ua");

            var bookService = new BookService();

            Console.WriteLine(Res.Resource.GetInfoMethodWorks);
            Console.WriteLine(bookService.GetInfoAboutBooks());

            Console.WriteLine(Res.Resource.AddMethodWorks);
            bookService.AddBook(new Book("My book 1", "Oleg Nemchinkiy", 2020, "Tag1"));
            bookService.AddBook(new Book("My book 2", "Oleg Nemchinkiy", 2020, "Tag1"));
            bookService.AddBook(new Book("My book 3", "Oleg Nemchinkiy", 2020, "Tag1"));

            Console.WriteLine(Res.Resource.GetInfoMethodWorks);
            Console.WriteLine(bookService.GetInfoAboutBooks());

            Console.WriteLine(Res.Resource.RemoveMethodWorks);
            bookService.RemoveBook("My book 1");

            Console.WriteLine(Res.Resource.GetInfoMethodWorks);
            Console.WriteLine(bookService.GetInfoAboutBooks());

            Console.WriteLine(Res.Resource.GetInfoMethodWorks);
            Console.WriteLine(bookService.GetInfoAboutBook("Book"));

            using (BookContext db = new BookContext())
            {
                db.Books.Add(new Book("My book 1", "Oleg Nemchinkiy", 2020, "Tag1"));
                db.Books.Add(new Book("My book 2", "Oleg Nemchinkiy", 2020, "Tag1"));
                db.Books.Add(new Book("My book 3", "Oleg Nemchinkiy", 2020, "Tag1"));
                db.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
