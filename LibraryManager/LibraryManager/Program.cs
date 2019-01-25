using LibraryManager;
using System;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var proc = new Processor();
            var UI = new UserInterface(proc);
=======
            var UI = new UserInterface(new Processor());
>>>>>>> 97c11702cd3eccb3abd757a09956ae04aebe7391
            UI.MainMenu();
        }
    }
}
