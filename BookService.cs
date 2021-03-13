using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagment
{
    class BookService
    {
        private List<Book> Books { get; set; }
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public BookService()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(string bookName)
        {
            Books.Remove(Books.FirstOrDefault(x => x.Name == bookName));
        }

        public string GetInfoAboutBook(string bookName)
        {
            try
            {
                var founded = Books.First(x => x.Name == bookName).ToString();
                return founded;
            }
            catch (Exception c)
            {
                logger.Error(c.Message);
                return null;
            }
        }

        public string GetInfoAboutBooks()
        {
            string info = string.Empty;

            foreach (var item in Books)
            {
                info += item.ToString() + '\n';
            }

            return info;
        }
    }
}
