using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment
{
    class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public string BookTag { get; set; }

        public Book(string name, string author, int year, string tag)
        {
            Name = name;
            Author = author;
            Year = year;
            BookTag = tag;
        }

        public override string ToString()
        {
            return $"{Name} {Author} {Year} {BookTag}";
        }
    }
}
