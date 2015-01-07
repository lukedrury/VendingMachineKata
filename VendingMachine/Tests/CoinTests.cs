using NUnit.Framework;

namespace VendingMachine.Tests
{
    public class CoinTests
    {
        [Test]
        public void FivePShouldHaveValue5()
        {
            Assert.That(Coin.New5p().Value, Is.EqualTo(5));
        }
 
        [Test]
        public void TenPShouldHaveValue10()
        {
            Assert.That(Coin.New10p().Value, Is.EqualTo(10));
        }

        [Test]
        public void TwentyPShouldHaveValue20()
        {
            Assert.That(Coin.New20p().Value, Is.EqualTo(20));
        }

        [Test]
        public void FiftyPShouldHaveValue50()
        {
            Assert.That(Coin.New50p().Value, Is.EqualTo(50));
        }

        [Test]
        public void OnePoundShouldHaveValue100()
        {
            Assert.That(Coin.New1Pound().Value, Is.EqualTo(100));
        }

        [Test]
        public void TwoPoundsShouldHaveValue200()
        {
            Assert.That(Coin.New2Pounds().Value, Is.EqualTo(200));
        }
    }
}