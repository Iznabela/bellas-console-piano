using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Keyboard
    {
        Layout layout = new Layout();

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
         */
        public void PlayManually()
        {
            ConsoleKeyInfo keyPress;

            do
            {
                keyPress = Console.ReadKey();
                foreach (var note in notes)
                {
                    if (keyPress.Key == note.GetKeyID())
                    {
                        Console.Write(note);
                        PlayNote(note.GetNoteID());
                    }
                }
            }
            while (keyPress.Key != ConsoleKey.D0); // while user hasn't entered 0
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
                        Console.Write(note);
                        PlayNote(note.GetNoteID());
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void PlayNote(string note_ID)
        {
            //TODO for loop instead of switch?
            // for (int i; i < sounds.)

            switch (note_ID)
            {
                case "C3":
                    sounds[0].Play();
                    layout.PlayLayout(note_ID);
                    break;
                case "C#":
                    sounds[1].Play();
                    break;
                case "D":
                    sounds[2].Play();
                    break;
                case "D#":
                    sounds[3].Play();
                    break;
                case "E":
                    sounds[4].Play();
                    break;
                case "F":
                    sounds[5].Play();
                    break;
                case "F#":
                    sounds[6].Play();
                    break;
                case "G":
                    sounds[7].Play();
                    break;
                case "G#":
                    sounds[8].Play();
                    break;
                case "A":
                    sounds[9].Play();
                    break;
                case "A#":
                    sounds[10].Play();
                    break;
                case "B":
                    sounds[11].Play();
                    break;
                case "C4":
                    sounds[12].Play();
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }
    }
}
