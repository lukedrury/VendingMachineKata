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
        public void ButtonOneShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.One.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("1"));            
        }

        [Test]
        public void ButtonTwoShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.Two.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("2"));
        }
        [Test]
        public void ButtonThreeShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.Three.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("3"));
        }
        [Test]
        public void ButtonFourShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.Four.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("4"));
        }
        [Test]
        public void ButtonFiveShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.Five.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("5"));
        }
        [Test]
        public void ButtonSixShouldShowInSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.Six.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo("6"));
        }

        [Test]
        public void ClearSelectionButtonShouldClearSelection()
        {
            var buttonPad = new ButtonPad();
            buttonPad.Six.Press();
            buttonPad.ClearSelection.Press();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo(""));
        }

    }
}
