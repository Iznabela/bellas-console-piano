using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Layout
    {
        StringBuilder rowOne = new StringBuilder(" _______________________________________________");
        StringBuilder rowTwo = new StringBuilder("|   |   |  |   |  |  |   |  |   |  |   |  |     |");
        StringBuilder rowThree = new StringBuilder("|   | W |  | E |  |  | T |  | Y |  | U |  |     |");
        StringBuilder rowFour = new StringBuilder("|   |___|  |___|  |  |___|  |___|  |___|  |     |");
        StringBuilder rowFive = new StringBuilder("|  A  |  S  |  D  |  F  |  G  |  H  |  J  |  K  |");
        StringBuilder rowSix = new StringBuilder("|_____|_____|_____|_____|_____|_____|_____|_____|");

        public void StandardLayout()
        {
            Console.WriteLine(rowOne);
            Console.WriteLine(rowTwo);
            Console.WriteLine(rowThree);
            Console.WriteLine(rowFour);
            Console.WriteLine(rowFive);
            Console.WriteLine(rowSix);
            Console.WriteLine();
        }

        // TODO make this method less "messy" and shorten the code somehow
        public void PlayLayout(string note_ID)
        {
            
            switch (note_ID)
            {
                case "C3":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  S  |  D  |  F  |  G  |  H  |  J  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "C#":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.Write("|   | ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine(" |  | E |  |  | T |  | Y |  | U |  |     |");
                    Console.WriteLine(rowFour);
                    Console.WriteLine(rowFive);
                    Console.WriteLine(rowSix);
                    break;
                case "D":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  D  |  F  |  G  |  H  |  J  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "D#":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.Write("|   | W |  | ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine(" |  |  | T |  | Y |  | U |  |     |");
                    Console.WriteLine(rowFour);
                    Console.WriteLine(rowFive);
                    Console.WriteLine(rowSix);
                    break;
                case "E":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  S  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  F  |  G  |  H  |  J  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "F":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  S  |  D  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  G  |  H  |  J  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "F#":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.Write("|   | W |  | E |  |  | ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine(" |  | Y |  | U |  |     |");
                    Console.WriteLine(rowFour);
                    Console.WriteLine(rowFive);
                    Console.WriteLine(rowSix);
                    break;
                case "G":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  S  |  D  |  F  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  H  |  J  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "G#":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.Write("|   | W |  | E |  |  | T |  | ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine(" |  | U |  |     |");
                    Console.WriteLine(rowFour);
                    Console.WriteLine(rowFive);
                    Console.WriteLine(rowSix);
                    break;
                case "A":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  S  |  D  |  F  |  G  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  J  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "A#":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.Write("|   | W |  | E |  |  | T |  | Y |  | ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine(" |  |     |");
                    Console.WriteLine(rowFour);
                    Console.WriteLine(rowFive);
                    Console.WriteLine(rowSix);
                    break;
                case "B":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  S  |  D  |  F  |  G  |  H  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |  K  |");
                    Console.WriteLine(rowSix);
                    break;
                case "C4":
                    Console.WriteLine(rowOne);
                    Console.WriteLine(rowTwo);
                    Console.WriteLine(rowThree);
                    Console.WriteLine(rowFour);
                    Console.Write("|  A  |  S  |  D  |  F  |  G  |  H  |  J  |  ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                    Console.WriteLine("  |");
                    Console.WriteLine(rowSix);              
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }            
        }
    }
}
