using LibraryManager;
using System;
using System.Collections.Generic;

namespace LibraryManager
{
    class UserInterface
    {
        private Processor processor;
        const string MENU_MESSAGE = "Inserisci:\n\n" +
                                        "'S' per mostrare tutti i libri;\n" +
                                        "'M' per mostrare i libri di un dato autore;\n" +
                                        "'A' per aggiungere un autore;\n" +
                                        "'B' per aggiungere un libro;\n" +
                                        "'R' per rimuovere un autore o un libro;\n" +
                                        "'C' per mostrare i libri di una data categoria;\n" +
                                        "'N' per vedere il numero dei libri di un dato autore;\n" +
                                        "'T' per mostrare in che magazzino si trova un libro;\n" +
                                        "'Q' per uscire dal programma;\n";

        public UserInterface(Processor processor)
        {
            this.processor = processor;
        }

        public void MainMenu()
        {
            Console.WriteLine(MENU_MESSAGE);
            string input = ReadAnswer().ToLower();

            switch (input[0])
            {
                case 's':
                    ShowAllBooks();
                    break;
                case 'm':
                    ShowBooksByAuthor();
                    break;
                case 'a':
                    AddAuthor();
                    break;
                case 'b':
                    AddBook();
                    break;
                case 'r':
                    Remove();
                    break;
                case 'c':
                    ShowByCategory();
                    break;
                case 'n':
                    NumberOfAuthorBooks();
                    break;
                case 't':
                    BookInStore();
                    break;
                case 'q':
                    return;
                default:
                    Console.WriteLine("La lettera non è valida, ritenta;");
                    break;
            }
            MainMenu();
        }

        private void ShowAllBooks()
        {
            processor.ShowAllBooks();
        }

        private void ShowBooksByAuthor()
        {
            processor.ShowBookByAuthor();
        }

        private void AddAuthor()
        {
            processor.AddAuthor();
        }

        private void AddBook()
        {
            string input = ReadAnswer("Inserisci nome e cognome dell'autore: ");
            processor.AddBook(input);
        }

        private void Remove()
        {
            Console.WriteLine("Vuoi cancellare un libro (L) o un autore (A)?");
            string input = ReadAnswer().ToLower();
            switch(input[0])
            {
                case 'l':
                    processor.RemoveBook();
                    break;
                case 'a':
                    processor.RemoveAuthor();
                    break;
                default :
                    Console.WriteLine("Inserimento non valido, ritenta");
                    Remove();
                    break;
            }
        }

        private void ShowByCategory()
        {
            processor.ShowByCategory();
        }

        private void NumberOfAuthorBooks()
        {
            processor.NumberOfAuthorBooks();
        }

        private void BookInStore()
        {
            processor.BookInStore();
        }

        private string ReadAnswer(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}

// Metodo() { using(var context = new EFLibraryContext) { ... } }