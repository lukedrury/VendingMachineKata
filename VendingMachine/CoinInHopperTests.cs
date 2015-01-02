using NUnit.Framework;

namespace VendingMachine
{
    class CoinInHopperTests
    {
        [Test]
        public void NewHopperShouldTotalZero()
        {
            var hopper = new CoinInHopper();
            Assert.That(hopper.TotalInserted, Is.EqualTo(0));
        }
    }
}