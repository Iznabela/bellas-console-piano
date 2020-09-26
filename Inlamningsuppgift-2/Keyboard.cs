using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Keyboard
    {
        Layout layout = new Layout();

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

        private List<SoundPlayer> sounds = new List<SoundPlayer>()
        {
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\C3.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\C#.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\D.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\D#.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\E.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\F.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\F#.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\G.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\G#.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\A.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\A#.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\B.wav"),
            new SoundPlayer(@"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\C4.wav")
        };

        /* To solve the problems of being able to play a keyboard
         * i started with initializing the class Soundplayer and trying to figure out how
         * to play just one soundfile with a key-input from the user.
         * In the next step i connected the note-objects to keys to be able to play different
         * notes for every key. And also printing out what note the user is playing by making a ToString method.
         * Then I worked on the design of the keyboard to make it more user-friendly.
         *
         * When I realised that I need a lot of different layouts to be able to print the keyboard in different
         * conditions I decided to create a new class for the layout.
         * 
         * Also - in the method PlayNote() I had a switch statement to compare the parameter with different notes, 
         * but made the code shorter by creating a string-array containing the notes, and comparing them inside a for-loop
         */
        public void PlayManually()
        {
            ConsoleKeyInfo keyInput;

            do
            {
                keyInput = Console.ReadKey(true);
                foreach (var note in notes)
                {
                    if (keyInput.Key == note.GetKeyID())
                    {
                        PlayNote(note.GetNoteID());
                        layout.WriteAt(note.ToString(), 1, 7);
                        Console.ResetColor();
                        layout.PlayLayout(note.GetNoteID());                     
                    }
                }
            }
            while (keyInput.Key != ConsoleKey.D0); // while user hasn't entered 0
        }

        public void PlayRandomly()
        {
            Random random = new Random();
            for (int plays = 0; plays <= 10; plays++)
            {
                int rd = random.Next(1, 13);

                foreach (var note in notes)
                {
                    if (rd == note.GetNumberID())
                    {
                        PlayNote(note.GetNoteID());
                        layout.WriteAt(note.ToString(), 1, 7);
                        Console.ResetColor();
                        layout.PlayLayout(note.GetNoteID());                        
                    }
                }
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
                    sounds[i].Play();
                }
            }
        }
    }
}
