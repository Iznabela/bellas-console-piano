using System;
using System.Media;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano keyboard = new Piano();
            Layout layout = new Layout();
            Console.CursorVisible = false;

            ConsoleKeyInfo keyInput;

            layout.StandardLayout();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            layout.WriteAt("[1] Play manually", 1, 9);
            layout.WriteAt("[2] Let computer play randomly", 1, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            layout.WriteAt("[esc] Exit", 1, 12);
            Console.ResetColor();

            keyInput = Console.ReadKey(true);

            if (keyInput.Key == ConsoleKey.NumPad1 || keyInput.Key == ConsoleKey.D1)
            {
                Console.Clear();
                layout.StandardLayout();
                keyboard.PlayManually();
            }
            else if (keyInput.Key == ConsoleKey.NumPad2 || keyInput.Key == ConsoleKey.D2)
            {
                Console.Clear();
                layout.StandardLayout();
                keyboard.PlayRandomly();
            }
            else if (keyInput.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
