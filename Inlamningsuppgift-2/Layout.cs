using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    public static class Layout
    {
        // starting points of row and column
        public static int rowStart;
        public static int columnStart;

        public static void WriteAt(string s, int x, int y)
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

        public static void PrintLayout()
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
    }
}
