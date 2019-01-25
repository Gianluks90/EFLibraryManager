using LibraryManager;
using System;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = new Processor();
            var UI = new UserInterface(proc);
            UI.MainMenu();
        }
    }
}
