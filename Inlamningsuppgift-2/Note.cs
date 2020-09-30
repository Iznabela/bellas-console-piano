﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Note
    {
        private string noteID;
        private string color;
        private ConsoleKey keyID;
        private int numberID;

        public Note(string NoteID, string Color, ConsoleKey UserKey, int NumberID)
        {
            noteID = NoteID;
            color = Color;
            keyID = UserKey;
            numberID = NumberID;
        }

        public string GetNoteID()
        {
            return noteID;
        }

        public ConsoleKey GetKeyID()
        {
            return keyID;
        }

        public int GetNumberID()
        {
            return numberID;
        }

        public override string ToString()
        {
            if (color == "white")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                return string.Format($" {noteID} ");
            }
            else if (color == "black")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                return string.Format($" {noteID} ");
            }
            else
            {
                return string.Format("Unvalid color");
            }
        }
    }
}
