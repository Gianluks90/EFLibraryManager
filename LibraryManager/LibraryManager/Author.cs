using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryManager
{
    public class Author
    {
        public int AuthorID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(75)]
        public string LastName { get; set; }
        public ICollection<Book> Books {get; set;} = new List<Book>();
    }
}