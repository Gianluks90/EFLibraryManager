using System;
using System.Collections.Generic;
using System.Text;
using LibraryManager;

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
                    
                    Console.WriteLine($"Titolo: {b.Title}, Autore: {find.FirstName +" "+ find.LastName}, Categoria: {b.Category};");
                }
            }
        }

        internal void ShowBookByAuthor()
        {
            using (var context = new LibraryContext())
            {
                // Stampa elenco autori con id
                foreach (var a in context.Authors)
                {
                    Console.WriteLine($"ID: {a.AuthorID}, Nome: {a.FirstName}, Cognome: {a.LastName};");
                }
                Console.WriteLine("Inserisci l'ID: ");
                int choice = Int32.Parse(ReadAnswer());
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
                throw new NotImplementedException();
            }
        }

        internal void RemoveBook()
        {
            using (var context = new LibraryContext())
            {
                throw new NotImplementedException();
            }
        }

        internal void RemoveAuthor()
        {
            using (var context = new LibraryContext())
            {
                throw new NotImplementedException();
            }
        }

        private string ReadAnswer(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
