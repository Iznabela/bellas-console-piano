using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Transactions;

namespace Inlamningsuppgift_2
{
    public class Piano
    {
        public bool isRandom = false;

        // fields to get the right working directory to be able to play soundfiles when opening the project on other units
        private static string workingDirectory = Directory.GetCurrentDirectory();
        private static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        private static string soundFiles = projectDirectory + @"\SoundFiles\";

        private static string[] sounds = new string[13];

        // creating note-objects which are added to the list
        private List<Note> notes = new List<Note>()
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

        public static void AddSounds()
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

            // lets user play as long as "esc" isn't entered
            do
            {
                keyInput = Console.ReadKey(true);

                if (keyInput.Key == ConsoleKey.NumPad1 || keyInput.Key == ConsoleKey.D1)
                {
                    PlayRandomly();
                }

                // checking if keyinput matches any notes
                foreach (var note in notes)
                {
                    if (keyInput.Key == note.GetKeyID())
                    {
                        PlayNote(note.GetNoteID()); // playing specific note
                        Layout.WriteAt(note.ToString(), 52, 1); // printing the note
                        Console.ResetColor();
                        Keystroke.PrintPlayedKey(note.GetNoteID(), isRandom); // printing keystroke on the specific key and reprints default state
                    }
                }
            } while (keyInput.Key != ConsoleKey.Escape);

            Environment.Exit(0);
        }

        /* letting the program play random notes on the keyboard
         * using random numbers instead of user input
         */
        public void PlayRandomly()
        {
            isRandom = true;

            Random random = new Random();

            for (int i = 0; i <= 20; i++)
            {
                int rd = random.Next(1, 13);

                foreach (var note in notes)
                {
                    if (rd == note.GetNumberID())
                    {
                        PlayNote(note.GetNoteID());
                        Layout.WriteAt(note.ToString(), 52, 1);
                        Console.ResetColor();
                        Keystroke.PrintPlayedKey(note.GetNoteID(), isRandom);
                    }
                }
            }
        }

        public static void PlayNote(string note_ID)
        {
            string[] notes = new string[13] { "C3", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C4" };

            // looping through the array of notes to play the right note
            for (int i = 0; i < notes.Length; i++)
            {
                if (note_ID == notes[i])
                {
                    new SoundPlayer(sounds[i]).Play();
                }
            }
        }

        public int AmountOfNotes()
        {
            int sum = 0;
            foreach (var note in notes)
            {
                sum++;
            }
            return sum;
        }
    }
}
