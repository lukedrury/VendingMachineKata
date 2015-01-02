using System.CodeDom;
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

        [Test]
        public void OneButtonPressShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.One.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("1"));
            
        }
    }
}
