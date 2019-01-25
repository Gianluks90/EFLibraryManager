using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManager
{
    partial class Processor
    {
        public void AddAuthor()
        {
            Console.WriteLine("First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name?");
            string lastName = Console.ReadLine();

            var author = new Author { FirstName = firstName, LastName = lastName };

            using (var context = new LibraryContext())
            {
                try
                {
                    context.Add(author);
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    Console.WriteLine("Insert error.");
                }
                Console.WriteLine("Insert ok.");
            }
        }

        public void ShowByCategory()
        {

        }

        public void NumberOfAuthorBooks()
        {

        }
    }
}
