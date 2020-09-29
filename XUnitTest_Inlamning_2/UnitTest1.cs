using Xunit;

namespace XUnitTest_Inlamning_2
{
    public class UnitTest1
    {
        Inlamningsuppgift_2.Piano keyboard = new Inlamningsuppgift_2.Piano();

        [Fact]
        public void AmountOfNotesTest()
        {
            Assert.Equal(13, keyboard.AmountOfNotes());
        }
    }
}
