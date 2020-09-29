using Inlamningsuppgift_2;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using Xunit;
using Xunit.Sdk;

namespace XUnitTest_Inlamning_2
{
    public class UnitTest1
    {
        Inlamningsuppgift_2.Keyboard keyboard = new Inlamningsuppgift_2.Keyboard();

        [Fact]
        public void AmountOfNotesTest()
        {
            Assert.Equal(13, keyboard.AmountOfNotes());
        }
    }
}
