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
            SoundPlayer simpleSound = new SoundPlayer(@"~Keyboard");
            var keyPress = Console.ReadKey();

            do
            {
                switch (keyPress.Key)
                {
                    case ConsoleKey.A:
                        simpleSound.Play();
                        Console.WriteLine(keyboard.NoteMatcher(ConsoleKey.A));

                        break;
                }
            }
            while (keyPress.Key != ConsoleKey.D0); // while user hasn't entered 0


            Console.ReadLine();
        }
    }
}
