using Microsoft.EntityFrameworkCore;

namespace LibraryManager
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ALLIEVO9;
                                            Initial Catalog=LibraryManager;
                                            Integrated Security=True;
                                            MultipleActiveResultSets=true");
        }
    }
}