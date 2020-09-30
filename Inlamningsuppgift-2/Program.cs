using System;
using System.Media;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new Piano();

            Console.CursorVisible = false;

            // printing the piano, adding soundfiles and letting user play
            Layout.PrintLayout();
            Piano.AddSounds();
            piano.PlayManually();
        }
    }
}
