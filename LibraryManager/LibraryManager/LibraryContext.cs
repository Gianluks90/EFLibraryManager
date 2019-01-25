using Microsoft.EntityFrameworkCore;

namespace LibraryManager
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Store> Stores {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=EFLibraryManager;
                                            Integrated Security=True;
                                            MultipleActiveResultSets=true");
        }
    }
}