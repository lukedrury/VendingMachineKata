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
        
        [Test]
        public void OneCoinShouldShowInTotal()
        {
            var hopper = new CoinInHopper();
            hopper.Insert(Coin.New5p());
            Assert.That(hopper.TotalInserted, Is.EqualTo(5));
        }
    }
}