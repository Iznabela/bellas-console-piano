using System;
using System.Media;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new Piano();
            Console.CursorVisible = false;

            ConsoleKeyInfo keyInput;

            Layout.PrintLayout();
            piano.AddSounds();
            piano.PlayManually();

            keyInput = Console.ReadKey(true);

            if (keyInput.Key == ConsoleKey.NumPad1 || keyInput.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Layout.PrintLayout();
                piano.PlayRandomly();
            }
            else if (keyInput.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
