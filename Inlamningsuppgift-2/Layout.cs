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
        int rowStart;
        int columnStart;

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

        // when a note is played - this method is called to temporary change the layout
        public void PlayLayout(string note_ID)
        {
            int[] rowPosSharpNotes = new int[8] { 1, 1, 1, 2, 2, 3, 3, 3 };

            switch (note_ID)
            {
                case "C3":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosC3 = new int[18] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 4, 5, 1, 2, 3, 4, 5 };
                        int[] rowPosC3 = new int[18] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosC3.Length; i++)
                        {
                            WriteAt("*", colPosC3[i], rowPosC3[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyC3();
                        break;
                    }                    
                case "C#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosCSharp = new int[8] { 5, 6, 7, 5, 7, 5, 6, 7 };

                        for (int i = 0; i < colPosCSharp.Length; i++)
                        {
                            WriteAt("*", colPosCSharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyCSharp();
                        break;
                    }                    
                case "D":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosD = new int[15] { 9, 10, 9, 10, 9, 10, 7, 8, 10, 11, 7, 8, 9, 10, 11 };
                        int[] rowPosD = new int[15] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosD.Length; i++)
                        {
                            WriteAt("*", colPosD[i], rowPosD[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyD();
                        break;
                    }                    
                case "D#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosDSharp = new int[8] { 12, 13, 14, 12, 14, 12, 13, 14 };

                        for (int i = 0; i < colPosDSharp.Length; i++)
                        {
                            WriteAt("*", colPosDSharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyDSharp();
                        break;
                    }                    
                case "E":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosE = new int[15] { 16, 17, 16, 17, 16, 17, 13, 14, 16, 17, 13, 14, 15, 16, 17 };
                        int[] rowPosE = new int[15] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosE.Length; i++)
                        {
                            WriteAt("*", colPosE[i], rowPosE[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyE();
                        break;
                    }                    
                case "F":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosF = new int[15] { 19, 20, 19, 20, 19, 20, 19, 20, 22, 23, 19, 20, 21, 22, 23 };
                        int[] rowPosF = new int[15] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosF.Length; i++)
                        {
                            WriteAt("*", colPosF[i], rowPosF[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyF();
                        break;
                    }
                case "F#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosFSharp = new int[8] { 22, 23, 24, 22, 24, 22, 23, 24 };

                        for (int i = 0; i < colPosFSharp.Length; i++)
                        {
                            WriteAt("*", colPosFSharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyFSharp();
                        break;
                    }
                case "G":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosG = new int[15] { 26, 27, 26, 27, 26, 27, 25, 26, 28, 29, 25, 26, 27, 28, 29 };
                        int[] rowPosG = new int[15] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosG.Length; i++)
                        {
                            WriteAt("*", colPosG[i], rowPosG[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyG();
                        break;
                    }
                case "G#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosGsharp = new int[8] { 29, 30, 31, 29, 31, 29, 30, 31 };

                        for (int i = 0; i < colPosGsharp.Length; i++)
                        {
                            WriteAt("*", colPosGsharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyGSharp();
                        break;
                    }
                case "A":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosA = new int[15] { 33, 34, 33, 34, 33, 34, 31, 32, 34, 35, 31, 32, 33, 34, 35 };
                        int[] rowPosA = new int[15] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosA.Length; i++)
                        {
                            WriteAt("*", colPosA[i], rowPosA[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyA();
                        break;
                    }
                case "A#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosASharp = new int[8] { 36, 37, 38, 36, 38, 36, 37, 38 };
                        
                        for (int i = 0; i < colPosASharp.Length; i++)
                        {
                            WriteAt("*", colPosASharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyASharp();
                        break;
                    }
                case "B":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosB = new int[15] { 40, 41, 40, 41, 40, 41, 37, 38, 40, 41, 37, 38, 39, 40, 41 };
                        int[] rowPosB = new int[15] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

                        for (int i = 0; i < colPosB.Length; i++)
                        {
                            WriteAt("*", colPosB[i], rowPosB[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyB();
                        break;
                    }
                case "C4":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosC4 = new int[24] { 43, 44, 45, 46, 47, 43, 44, 45, 46, 47, 43, 44, 45, 46, 47, 43, 44, 46, 47, 43, 44, 45, 46, 47 };
                        int[] rowPosC4 = new int[24] { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
                        
                        for (int i = 0; i < colPosC4.Length; i++)
                        {
                            WriteAt("*", colPosC4[i], rowPosC4[i]);
                        }
                        Console.ResetColor();
                        Thread.Sleep(500);
                        ReprintKeyC4();
                        break;
                    }
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }

        public void ReprintKeyC3()
        {
            int[] spaceColPostition = new int[13] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 4, 5 };
            int[] spaceRowPosition = new int[13] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4 };            

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
        }

        public void ReprintKeyCSharp()
        {
            int[] spaceColPosition = new int[5] { 5, 6, 7, 5, 7 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };            

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 5; colNumber <= 7; colNumber++)
            {
                WriteAt("_", colNumber, 3);
            }
        }

        public void ReprintKeyD()
        {
            int[] spaceColPosition = new int[10] { 9, 10, 9, 10, 9, 10, 7, 8, 10, 11 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 7; colNumber <= 11; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }

        public void ReprintKeyDSharp()
        {
            int[] spaceColPosition = new int[5] { 12, 13, 14, 12, 14 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 12; colNumber <= 14; colNumber++)
            {
                WriteAt("_", colNumber, 3);
            }
        }

        public void ReprintKeyE()
        {
            int[] spaceColPosition = new int[10] { 16, 17, 16, 17, 16, 17, 13, 14, 16, 17 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 13; colNumber <= 17; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }

        public void ReprintKeyF()
        {
            int[] spaceColPosition = new int[10] { 19, 20, 19, 20, 19, 20, 19, 20, 22, 23 };
            int[] rowColPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], rowColPosition[i]);
            }

            for (int colNumber = 19; colNumber <= 23; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }

        public void ReprintKeyFSharp()
        {
            int[] spaceColPosition = new int[5] { 22, 23, 24, 22, 24 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 22; colNumber <= 24; colNumber++)
            {
                WriteAt("_", colNumber, 3);
            }
        }

        public void ReprintKeyG()
        {
            int[] spaceColPosition = new int[10] { 26, 27, 26, 27, 26, 27, 25, 26, 28, 29 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 25; colNumber <= 29; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }

        public void ReprintKeyGSharp()
        {
            int[] spaceColPosition = new int[5] { 29, 30, 31, 29, 31 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 29; colNumber <= 31; colNumber++)
            {
                WriteAt("_", colNumber, 3);
            }
        }

        public void ReprintKeyA()
        {
            int[] spaceColPosition = new int[10] { 33, 34, 33, 34, 33, 34, 31, 32, 34, 35 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 31; colNumber <= 35; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }

        public void ReprintKeyASharp()
        {
            int[] spaceColPosition = new int[5] { 36, 37, 38, 36, 38 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 36; colNumber <= 38; colNumber++)
            {
                WriteAt("_", colNumber, 3);
            }
        }

        public void ReprintKeyB()
        {
            int[] spaceColPosition = new int[10] { 40, 41, 40, 41, 40, 41, 37, 38, 40, 41 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 37; colNumber <= 41; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }

        public void ReprintKeyC4()
        {
            int[] spaceColPosition = new int[19] { 43, 44, 45, 46, 47, 43, 44, 45, 46, 47, 43, 44, 45, 46, 47, 43, 44, 46, 47 };
            int[] spaceRowPosition = new int[19] { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 43; colNumber <= 47; colNumber++)
            {
                WriteAt("_", colNumber, 5);
            }
        }
    }
}
