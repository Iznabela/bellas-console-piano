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
            keyboardSounds.SoundLocation = Environment.CurrentDirectory + "/Inlamningsuppgift-2/Sound Files/C3.wav";
            var keyPress = Console.ReadKey();

            do
            {
                switch (keyPress.Key)
                {
                    case ConsoleKey.A:
                        keyboardSounds.Play();
                        Console.WriteLine(NoteMatcher(ConsoleKey.A));

                        break;
                }
            }
            while (keyPress.Key != ConsoleKey.D0); // while user hasn't entered 0
        }

        private List<Note> notes = new List<Note>()
            {
                new Note("C", "white", ConsoleKey.A),
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
                new Note("C", "white", ConsoleKey.K)
            };

        // checking if the key user entered matches with any key in keyboard
        // if it does it will return the noteID so it can be printed out
        public string NoteMatcher(ConsoleKey k)
        {
            string playedKey = null;
            foreach (var note in notes)
            {
                if (k == note.GetUserKey())
                {
                    playedKey = note.GetNoteID();
                }
                else
                {
                    return "Invalid key";
                }
            }
            return playedKey;
        }
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
