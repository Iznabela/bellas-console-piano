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

        // TODO print what key is currently being played in a cool way
        public void PlayLayout(string note_ID)
        {
            switch (note_ID)
            {
                case "C3":
                    rowFive.Replace(" A ", " C ");
                    Console.Clear();
                    StandardLayout();
                    break;
                    /*
                case "C#":
                    break;
                case "D":
                    break;
                case "D#":
                    break;
                case "E":
                    break;
                case "F":
                    break;
                case "F#":
                    break;
                case "G":
                    break;
                case "G#":
                    break;
                case "A":
                    break;
                case "A#":
                    break;
                case "B":
                    break;
                case "C4":
                    break; */
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }
    }
}
