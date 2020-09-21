using System;
using System.Collections.Generic;
using System.Media;

namespace Inlamningsuppgift_2
{
    class Keyboard
    {
        public void PlayKeyboard()
        {
            SoundPlayer keyboardSounds = new SoundPlayer();
            // keyboardSounds.SoundLocation = Environment.CurrentDirectory + "C3.wav";

            keyboardSounds.SoundLocation = @"C:\Users\isabe\source\repos\Inlamningsuppgift-2\Inlamningsuppgift-2\SoundFiles\C3.wav";

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
                        // keyboardSounds.PlaySync();
                    }
                }
            }
            while (keyPress.Key != ConsoleKey.Escape); // while user hasn't entered esc
        }

        public void Manual()
        {
            // TODO Foreach loop to print keys
            Console.WriteLine("Enter these keys ->    [W]   [E]         [T]   [Y]   [U]");
            Console.WriteLine("For these notes ->    | C#| | D#|       | F#| | G#| | A#|");
            Console.WriteLine("Enter these keys ->  [A]   [S]   [D]   [F]   [G]   [H]   [J]   [K]");
            Console.WriteLine("For these notes ->  | C | | D | | E | | F | | G | | A | | B | | C |");
        }

        public void PlayNote(string note_ID)
        {
            switch (note_ID)
            {
                case "C3":
                    sounds[0].Play();
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

        private List<Note> notes = new List<Note>()
        {
            new Note("C3", "white", ConsoleKey.A),
            new Note("C#", "black", ConsoleKey.W),
            new Note("D", "white", ConsoleKey.S),
            new Note("D#", "black", ConsoleKey.E),
            new Note("E", "white", ConsoleKey.D),
            new Note("F", "white", ConsoleKey.F),
            new Note("F#", "black", ConsoleKey.T),
            new Note("G", "white", ConsoleKey.G),
            new Note("G#", "black", ConsoleKey.Y),
            new Note("A", "white", ConsoleKey.H),
            new Note("A#", "black", ConsoleKey.U),
            new Note("B", "white", ConsoleKey.J),
            new Note("C4", "white", ConsoleKey.K)
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

        // checking if the key user entered matches with any key in keyboard
        // if it does it will return the noteID so it can be printed out
        // ALTERNATIVT ANVÄNDAS
        /*
        public Note NoteMatcher(ConsoleKey k)
        {
            string playedKey;
            foreach (var note in notes)
            {
                if (k == note.GetKeyID())
                {
                    playedKey = note.GetNoteID();
                }
                return note;
            }
            return 
        }
        */


        /* ALTERNATIV ARRAY
        Note[] notes = new Note[12];

        notes[0] = new Note("C", "white", 'a');
        notes[1] = new Note("C#", "black", 'w');
        notes[2] = new Note("D", "white", 's');
        notes[3] = new Note("D#", "black", 'e');
        notes[4] = new Note("E", "white", 'd');
        notes[5] = new Note("F", "white", 'f');
        notes[6] = new Note("F#", "black", 't');
        notes[7] = new Note("G", "white", 'g');
        notes[8] = new Note("G#", "black", 'y');
        notes[9] = new Note("A", "white", 'h');
        notes[10] = new Note("A#", "black", 'u');
        notes[11] = new Note("B", "white", 'j');
        notes[12] = new Note("C", "white", 'k');
        return notes;
        */
    }
}
