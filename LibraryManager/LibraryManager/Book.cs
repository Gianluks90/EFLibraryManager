using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        public int StoreId { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

}