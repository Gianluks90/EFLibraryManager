using System;
using System.Collections.Generic;
namespace LibraryManager
{
    partial class Processor
    {
        internal void ShowAllBooks()
        {
            using (var context = new LibraryContext())
            {
                foreach (var b in context.Books)
                {
                    var idA = b.AuthorId;
                    var find = context.Authors.Find(idA);
                    
                    Console.WriteLine($"ID: {b.BookId} - Titolo: {b.Title}, Autore: {find.FirstName +" "+ find.LastName}, Categoria: {b.Category};");
                }
            }
        }

        internal void ShowBookByAuthor()
        {
            using (var context = new LibraryContext())
            {
                foreach (var a in context.Authors)
                {
                    Console.WriteLine($"ID: {a.AuthorID}, Nome: {a.FirstName}, Cognome: {a.LastName};");
                }
                int choice = Int32.Parse(ReadAnswer("Inserisci l'ID: "));
                foreach(var b in context.Books)
                {
                   if(b.AuthorId == choice)
                   {
                        Console.WriteLine($"Titolo: {b.Title}, Categoria: {b.Category}");
                   }
                }
            }
        }

        internal void AddBook(string input)
        {
            using (var context = new LibraryContext())
            {
                var i = input.Split(' ');
                var author = new Author
                {
                    FirstName = i[0],
                    LastName = i[1],
                    Books = new List<Book>
                    {
                        new Book {Title = ReadAnswer("Inserisci il titolo del libro: "),
                                  Category = ReadAnswer("Inserisci la categoria del libro: ")
                        }
                    }    
                };
                context.Add(author);
                context.SaveChanges();
            }
        }

        internal void RemoveBook()
        {
            using (var context = new LibraryContext())
            {
                ShowAllBooks();
                int input = Int32.Parse(ReadAnswer("Inserisci l'ID: "));
                context.Remove(context.Books.Find(input));
                context.SaveChanges();
            }
        }

        internal void RemoveAuthor()
        {
            using (var context = new LibraryContext())
            {
                foreach (var a in context.Authors)
                {
                    Console.WriteLine($"ID: {a.AuthorID}, Nome: {a.FirstName}, Cognome: {a.LastName};");
                }
                int input = Int32.Parse(ReadAnswer("Inserisci l'ID: "));
                context.Remove(context.Authors.Find(input));
                context.SaveChanges();
            }
        }

        private string ReadAnswer(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
