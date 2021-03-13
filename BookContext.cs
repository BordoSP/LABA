using System.Data.Entity;

namespace LibraryManagment
{
    class BookContext : DbContext
    {
        public BookContext()
           : base("DbConnection")
        { }

        public DbSet<Book> Books { get; set; }
    }
}
