using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    public class Layout
    {
        // members for starting point of rows and columns
        public int rowStart;
        public int columnStart;

        public void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(columnStart + x, rowStart + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void StandardLayout()
        {
            rowStart = 0;
            columnStart = 0;

            // printing row 1
            for (int i = 1; i < 48; i++)
            {
                WriteAt("_", i, 0);
            }

            // contains the column position numbers for the vertical lines in row 2
            int[] rowTwoColVertLines = new int[14] { 0, 4, 8, 11, 15, 18, 21, 25, 28, 32, 35, 39, 42, 48 };

            // printing row 2
            foreach (var number in rowTwoColVertLines)
            {
                WriteAt("|", number, 1);
            }

            // contains the column position numbers for the vertical lines in row 3
            int[] rowThreeColVertLines = new int[14] { 0, 4, 8, 11, 15, 18, 21, 25, 28, 32, 35, 39, 42, 48 };

            // printing vertical lines for row 3
            foreach (var colNumber in rowThreeColVertLines)
            {
                WriteAt("|", colNumber, 2);
            }

            string[] rowThreeLetters = new string[5] { "W", "E", "T", "Y", "U" };
            int[] rowThreeColLetterPositions = new int[5] { 6, 13, 23, 30, 37 };

            // printing letters for row 3
            for (int i = 0; i < rowThreeColLetterPositions.Length; i++)
            {
                WriteAt(rowThreeLetters[i], rowThreeColLetterPositions[i], 2);
            }
                        
            // contains the column position numbers for the vertical lines in row 4
            int[] rowFourColVertLines = new int[14] { 0, 4, 8, 11, 15, 18, 21, 25, 28, 32, 35, 39, 42, 48 };

            foreach (var colNumber in rowFourColVertLines)
            {
                WriteAt("|", colNumber, 3);
            }

            int[] rowFourColUnderScores = new int[15] { 5, 6, 7, 12, 13, 14, 22, 23, 24, 29, 30, 31, 36, 37, 38 };

            foreach (var colNumber in rowFourColUnderScores)
            {
                WriteAt("_", colNumber, 3);
            }

            // printing vertical lines for row 5
            for (int i = 0; i <= 48; i += 6)
            {
                WriteAt("|", i, 4);
            }

            string[] rowFiveLetters = new string[8] { "A", "S", "D", "F", "G", "H", "J", "K" };
            int rowFiveColLetterPosition = 3;

            for (int i = 0; i < rowFiveLetters.Length; i++)
            {
                WriteAt(rowFiveLetters[i], rowFiveColLetterPosition, 4);
                rowFiveColLetterPosition += 6;
            }

            // printing vertical lines for row 6
            for (int i = 0; i <= 48; i += 6)
            {
                WriteAt("|", i, 5);
            }

            // printing underscores for row 6
            for (int i = 1; i <= 48; i += 6)
            {
                for (int j = 0; j < 5; j++)
                {
                    WriteAt("_", i + j, 5);
                }
            }

        }

        // TODO continue making arrays and for-loops instead of just a lot of "WriteAt:s"
        public void PlayLayout(string note_ID)
        {

            switch (note_ID)
            {
                case "C3":
                    int[] colPosC3 = new int[19] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
                    int[] rowPosC3 = new int[19] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int i = 0; i < colPosC3.Length; i++)
                    {
                        WriteAt("*", colPosC3[i], rowPosC3[i]);
                    }
                    Console.ResetColor();
                    //WriteAt("*", 1, 1);
                    //WriteAt("*", 2, 1);
                    //WriteAt("*", 3, 1);
                    //WriteAt("*", 1, 2);
                    //WriteAt("*", 2, 2);
                    //WriteAt("*", 3, 2);
                    //WriteAt("*", 1, 3);
                    //WriteAt("*", 2, 3);
                    //WriteAt("*", 3, 3);
                    //WriteAt("*", 1, 4);
                    //WriteAt("*", 2, 4);
                    //WriteAt("*", 3, 4);
                    //WriteAt("*", 4, 4);
                    //WriteAt("*", 5, 4);
                    //WriteAt("*", 1, 5);
                    //WriteAt("*", 2, 5);
                    //WriteAt("*", 3, 5);
                    //WriteAt("*", 4, 5);
                    //WriteAt("*", 5, 5);
                    Console.ResetColor();
                    Thread.Sleep(500);
                    ReprintKeyA();
                    break;
                case "C#":
                    int[] colPosCSharp = new int[9] { 5, 6, 7, 5, 6, 7, 5, 6, 7 };
                    int[] rowPosCSharp = new int[9] { 1, 1, 1, 2, 2, 2, 3, 3, 3 };

                    Console.BackgroundColor = ConsoleColor.Red;

                    for (int i = 0; i < colPosCSharp.Length; i++)
                    {
                        WriteAt("*", colPosCSharp[i], rowPosCSharp[i]);
                    }
                    Console.ResetColor();
                    Thread.Sleep(500);
                    ReprintKeyW();
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

                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }

        public void ReprintKeyA()
        {
            int[] spaceRowPosition = new int[13] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            int[] spaceColPostition = new int[13] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 4, 5 };

            // printing spaces
            for (int i = 0; i < spaceColPostition.Length; i++)
            {
                    WriteAt(" ", spaceColPostition[i], spaceRowPosition[i]);
            }

            // printing underscores
            for (int colNumber = 1; colNumber <= 5; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }

            // printing A in the right position
            WriteAt("A", 3, 4);
        }

        public void ReprintKeyW()
        {
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };
            int[] spaceColPosition = new int[5] { 5, 6, 7, 5, 7 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 6; colNumber <= 8; colNumber++)
            {
                WriteAt("_", colNumber, 3);
            }
        }
    }
}
