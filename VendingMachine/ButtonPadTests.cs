using NUnit.Framework;

namespace VendingMachine
{
    public class ButtonPadTests
    {
        [Test]
        public void ShouldStartWithNoSelection()
        {
            var buttonPad = new ButtonPad();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo(""));
        }
    }
}
