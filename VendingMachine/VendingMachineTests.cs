using NUnit.Framework;

namespace VendingMachine
{
    class VendingMachineTests
    {
        [Test]
        public void NewMachineShouldShowReady()
        {
            var machine = new VendingMachine();
            Assert.That(machine.Display.Row1, Is.EqualTo("Ready"));
        }

        [Test]
        public void MachineShouldShowSelection()
        {
            var machine = new VendingMachine();
            machine.ButtonPad.One.Press();
            machine.ButtonPad.Two.Press();
            machine.ButtonPad.Three.Press();
            Assert.That(machine.Display.Row1, Is.EqualTo("123"));
        }

        [Test]
        public void MachineShouldClearSelection()
        {
            var machine = new VendingMachine();
            machine.ButtonPad.One.Press();
            machine.ButtonPad.Two.Press();
            machine.ButtonPad.Three.Press();
            machine.ButtonPad.ClearSelection.Press();
            Assert.That(machine.Display.Row1, Is.EqualTo("Ready"));            
        }
    }
}