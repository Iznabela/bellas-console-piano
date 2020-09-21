using System;
using System.Media;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Keyboard keyboard = new Keyboard();

            Console.WriteLine("Press any key to play keyboard...");
            Console.ReadLine();
            keyboard.PlayKeyboard();

            Console.ReadLine();
        }
    }
}
