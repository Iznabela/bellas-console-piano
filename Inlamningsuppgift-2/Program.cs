using System;
using System.Media;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();

            Console.WriteLine("Welcome to the Keyboard!");
            Console.WriteLine("[1] > Play with manual");
            Console.WriteLine("[2] > Play without manual");
            string userInput = Console.ReadLine();
            int menuChoice;
            bool success = Int32.TryParse(userInput, out menuChoice);

            if (success)
            {
                if (menuChoice == 1)
                {
                    Console.Clear();
                    keyboard.Manual();
                    Console.WriteLine();
                    keyboard.PlayKeyboard();
                    
                }
                else if (menuChoice == 2)
                {
                    Console.Clear();
                    keyboard.PlayKeyboard();
                }
            }
            keyboard.PlayKeyboard();

            Console.ReadLine();
        }
    }
}
