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
            Layout layout = new Layout();

            Console.WriteLine("Welcome to the Keyboard!");
            Console.WriteLine("[1] > Play keyboard manually");
            Console.WriteLine("[2] > Let computer play randomly");
            string userInput = Console.ReadLine();
            int menuChoice;
            bool success = Int32.TryParse(userInput, out menuChoice);

            if (success)
            {
                if (menuChoice == 1)
                {
                    Console.Clear();
                    layout.StandardLayout();
                    keyboard.PlayManually();
                    
                }
                else if (menuChoice == 2)
                {
                    Console.Clear();
                    layout.StandardLayout();
                    keyboard.PlayRandomly();
                }
            }

            Console.ReadLine();
        }
    }
}
