using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    class CoinInHopper : ICoinSlot
    {
        public CoinInHopper(Action coinInsertedAction)
        {
            m_CoinInsertedAction = coinInsertedAction;
        }

        public void Insert(ICoin coin)
        {
            m_Coins.Add(coin);
            m_CoinInsertedAction();
        }

        public int TotalInserted
        {
            get { return m_Coins.Sum(coin => coin.Value); }
        }

        private readonly List<ICoin> m_Coins = new List<ICoin>();
        private readonly Action m_CoinInsertedAction;
    }
}
