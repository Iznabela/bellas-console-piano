using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Note
    {
        private string noteID { get; set; }
        private string color { get; set; }
        private ConsoleKey userKey { get; set; }

        public Note(string NoteID, string Color, ConsoleKey UserKey)
        {
            noteID = NoteID;
            color = Color;
            userKey = UserKey;
        }

        public string GetNoteID()
        {
            return noteID;
        }

        public ConsoleKey GetUserKey()
        {
            return userKey;
        }


        public override string ToString()
        {
            if (color == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                return string.Format($"♪ {noteID} ♪");
            }
            else if (color == "black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                return string.Format($"♪ {noteID} ♪");
            }
            else
            {
                return string.Format("ERROR");
            }
        }
    }
}
