﻿using NUnit.Framework;

namespace VendingMachine.Tests
{
    class CoinInHopperTests
    {
        [Test]
        public void NewHopperShouldTotalZero()
        {
            var hopper = new CoinInHopper(() => { });
            Assert.That(hopper.TotalInserted, Is.EqualTo(0));
        }
        
        [Test]
        public void OneCoinShouldShowInTotal()
        {
            var hopper = new CoinInHopper(() => { });
            hopper.Insert(Coin.New5p());
            Assert.That(hopper.TotalInserted, Is.EqualTo(5));
        }

        [Test]
        public void SeveralCoinsShouldShowInTotal()
        {
            var hopper = new CoinInHopper(() => { });
            hopper.Insert(Coin.New5p());
            hopper.Insert(Coin.New10p());
            hopper.Insert(Coin.New50p());
            Assert.That(hopper.TotalInserted, Is.EqualTo(65));
        }
    }
}