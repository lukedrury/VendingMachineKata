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
    }
}