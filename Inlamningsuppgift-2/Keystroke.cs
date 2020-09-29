using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    // contains methods that prints red patterns on the piano-keys and reprints the default state
    public static class Keystroke
    {
        // when a note is played - this method is called to temporary change the layout
        public static void PrintPlayedKey(string note_ID, bool isRandom)
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
                            Layout.WriteAt("*", colPosC3[i], rowPosC3[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
                        ReprintKeyC3();
                        break;
                    }
                case "C#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosCSharp = new int[8] { 5, 6, 7, 5, 7, 5, 6, 7 };

                        for (int i = 0; i < colPosCSharp.Length; i++)
                        {
                            Layout.WriteAt("*", colPosCSharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosD[i], rowPosD[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
                        ReprintKeyD();
                        break;
                    }
                case "D#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosDSharp = new int[8] { 12, 13, 14, 12, 14, 12, 13, 14 };

                        for (int i = 0; i < colPosDSharp.Length; i++)
                        {
                            Layout.WriteAt("*", colPosDSharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosE[i], rowPosE[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosF[i], rowPosF[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
                        ReprintKeyF();
                        break;
                    }
                case "F#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosFSharp = new int[8] { 22, 23, 24, 22, 24, 22, 23, 24 };

                        for (int i = 0; i < colPosFSharp.Length; i++)
                        {
                            Layout.WriteAt("*", colPosFSharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosG[i], rowPosG[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
                        ReprintKeyG();
                        break;
                    }
                case "G#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosGsharp = new int[8] { 29, 30, 31, 29, 31, 29, 30, 31 };

                        for (int i = 0; i < colPosGsharp.Length; i++)
                        {
                            Layout.WriteAt("*", colPosGsharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosA[i], rowPosA[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
                        ReprintKeyA();
                        break;
                    }
                case "A#":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int[] colPosASharp = new int[8] { 36, 37, 38, 36, 38, 36, 37, 38 };

                        for (int i = 0; i < colPosASharp.Length; i++)
                        {
                            Layout.WriteAt("*", colPosASharp[i], rowPosSharpNotes[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosB[i], rowPosB[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
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
                            Layout.WriteAt("*", colPosC4[i], rowPosC4[i]);
                        }
                        Console.ResetColor();
                        if (isRandom == true) { Thread.Sleep(500); }
                        else { Thread.Sleep(200); }
                        ReprintKeyC4();
                        break;
                    }
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }

        public static void ReprintKeyC3()
        {
            int[] spaceColPostition = new int[13] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 4, 5 };
            int[] spaceRowPosition = new int[13] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            // printing spaces
            for (int i = 0; i < spaceColPostition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPostition[i], spaceRowPosition[i]);
            }

            // printing underscores
            for (int colNumber = 1; colNumber <= 5; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyCSharp()
        {
            int[] spaceColPosition = new int[5] { 5, 6, 7, 5, 7 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 5; colNumber <= 7; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 3);
            }
        }

        public static void ReprintKeyD()
        {
            int[] spaceColPosition = new int[10] { 9, 10, 9, 10, 9, 10, 7, 8, 10, 11 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 7; colNumber <= 11; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyDSharp()
        {
            int[] spaceColPosition = new int[5] { 12, 13, 14, 12, 14 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 12; colNumber <= 14; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 3);
            }
        }

        public static void ReprintKeyE()
        {
            int[] spaceColPosition = new int[10] { 16, 17, 16, 17, 16, 17, 13, 14, 16, 17 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 13; colNumber <= 17; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyF()
        {
            int[] spaceColPosition = new int[10] { 19, 20, 19, 20, 19, 20, 19, 20, 22, 23 };
            int[] rowColPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], rowColPosition[i]);
            }

            for (int colNumber = 19; colNumber <= 23; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyFSharp()
        {
            int[] spaceColPosition = new int[5] { 22, 23, 24, 22, 24 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 22; colNumber <= 24; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 3);
            }
        }

        public static void ReprintKeyG()
        {
            int[] spaceColPosition = new int[10] { 26, 27, 26, 27, 26, 27, 25, 26, 28, 29 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 25; colNumber <= 29; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyGSharp()
        {
            int[] spaceColPosition = new int[5] { 29, 30, 31, 29, 31 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 29; colNumber <= 31; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 3);
            }
        }

        public static void ReprintKeyA()
        {
            int[] spaceColPosition = new int[10] { 33, 34, 33, 34, 33, 34, 31, 32, 34, 35 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 31; colNumber <= 35; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyASharp()
        {
            int[] spaceColPosition = new int[5] { 36, 37, 38, 36, 38 };
            int[] spaceRowPosition = new int[5] { 1, 1, 1, 2, 2 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 36; colNumber <= 38; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 3);
            }
        }

        public static void ReprintKeyB()
        {
            int[] spaceColPosition = new int[10] { 40, 41, 40, 41, 40, 41, 37, 38, 40, 41 };
            int[] spaceRowPosition = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 37; colNumber <= 41; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }

        public static void ReprintKeyC4()
        {
            int[] spaceColPosition = new int[19] { 43, 44, 45, 46, 47, 43, 44, 45, 46, 47, 43, 44, 45, 46, 47, 43, 44, 46, 47 };
            int[] spaceRowPosition = new int[19] { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4 };

            for (int i = 0; i < spaceColPosition.Length; i++)
            {
                Layout.WriteAt(" ", spaceColPosition[i], spaceRowPosition[i]);
            }

            for (int colNumber = 43; colNumber <= 47; colNumber++)
            {
                Layout.WriteAt("_", colNumber, 5);
            }
        }
    }
}
