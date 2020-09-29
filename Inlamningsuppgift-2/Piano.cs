using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.IO;
using System.Media;
using System.Threading;
using System.Transactions;

namespace Inlamningsuppgift_2
{
    public class Piano
    {
        public static bool isRandom = false;
        static string workingDirectory = Directory.GetCurrentDirectory();
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        string soundFiles = projectDirectory + @"\SoundFiles\";

        string[] sounds = new string[13];

        // creating note-objects which are added to the list
        public List<Note> notes = new List<Note>()
        {
            new Note("C3", "white", ConsoleKey.A, 1),
            new Note("C#", "black", ConsoleKey.W, 2),
            new Note("D", "white", ConsoleKey.S, 3),
            new Note("D#", "black", ConsoleKey.E, 4),
            new Note("E", "white", ConsoleKey.D, 5),
            new Note("F", "white", ConsoleKey.F, 6),
            new Note("F#", "black", ConsoleKey.T, 7),
            new Note("G", "white", ConsoleKey.G, 8),
            new Note("G#", "black", ConsoleKey.Y, 9),
            new Note("A", "white", ConsoleKey.H, 10),
            new Note("A#", "black", ConsoleKey.U, 11),
            new Note("B", "white", ConsoleKey.J, 12),
            new Note("C4", "white", ConsoleKey.K, 13)
        };

        public int AmountOfNotes()
        {
            int sum = 0;
            foreach (var note in notes)
            {
                sum++;
            }
            return sum;
        }

        public void AddSounds()
        {
            sounds[0] = soundFiles + @"C3.wav";
            sounds[1] = soundFiles + @"C#.wav";
            sounds[2] = soundFiles + @"D.wav";
            sounds[3] = soundFiles + @"D#.wav";
            sounds[4] = soundFiles + @"E.wav";
            sounds[5] = soundFiles + @"F.wav";
            sounds[6] = soundFiles + @"F#.wav";
            sounds[7] = soundFiles + @"G.wav";
            sounds[8] = soundFiles + @"G#.wav";
            sounds[9] = soundFiles + @"A.wav";
            sounds[10] = soundFiles + @"A#.wav";
            sounds[11] = soundFiles + @"B.wav";
            sounds[12] = soundFiles + @"C4.wav";
        }

        public void PlayManually()
        {
            isRandom = false;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Layout.WriteAt($"--- Play notes by entering any of the {AmountOfNotes()} letters printed on the piano above ---", 1, 9);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Layout.WriteAt("[1] Let computer play randomly", 5, 12);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Layout.WriteAt("[esc] Exit", 5, 16);
            Console.ResetColor();

            ConsoleKeyInfo keyInput;
            do
            {
                keyInput = Console.ReadKey(true);

                if (keyInput.Key == ConsoleKey.NumPad1 || keyInput.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Layout.PrintLayout();
                    PlayRandomly();
                }

                foreach (var note in notes)
                {
                    if (keyInput.Key == note.GetKeyID())
                    {
                        PlayNote(note.GetNoteID());
                        Layout.WriteAt(note.ToString(), 1, 7);
                        Console.ResetColor();
                        Keystroke.PrintPlayedKey(note.GetNoteID(), isRandom);
                    }
                }
            } while (keyInput.Key != ConsoleKey.Escape);
            Environment.Exit(0);
        }

        // letting the computer play random notes on the keyboard
        public void PlayRandomly()
        {
            isRandom = true;
            Random random = new Random();

            ConsoleKeyInfo keyInput;

            for (int i = 0; i <= 20; i++)
            {
                int rd = random.Next(1, 13);

                foreach (var note in notes)
                {
                    if (rd == note.GetNumberID())
                    {
                        PlayNote(note.GetNoteID());
                        Layout.WriteAt(note.ToString(), 1, 7);
                        Console.ResetColor();
                        Keystroke.PrintPlayedKey(note.GetNoteID(), isRandom);
                    }
                }
            }            

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Layout.WriteAt("[1] Let computer play again", 5, 9);
            Layout.WriteAt("[2] Play manually", 5, 12);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Layout.WriteAt("[esc] Exit", 5, 16);
            Console.ResetColor();

            keyInput = Console.ReadKey(true);

            if (keyInput.Key == ConsoleKey.NumPad1 || keyInput.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Layout.PrintLayout();
                PlayRandomly();
            }
            else if (keyInput.Key == ConsoleKey.NumPad2 || keyInput.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Layout.PrintLayout();
                PlayManually();
            }
            else if (keyInput.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

        }

        public void PlayNote(string note_ID)
        {
            // array of the notes to be able to loop through and compare matches
            string[] notes = new string[13] { "C3", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C4" };

            for (int i = 0; i < notes.Length; i++)
            {
                if (note_ID == notes[i])
                {
                    new SoundPlayer(sounds[i]).Play();
                }
            }
        }
    }
}
