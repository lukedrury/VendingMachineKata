using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    class CoinInHopper
    {
        private readonly List<ICoin> m_Coins = new List<ICoin>();
        public void Insert(ICoin coin)
        {
            m_Coins.Add(coin);
        }

        public int TotalInserted
        {
            get { return m_Coins.Sum(coin => coin.Value); }
        }
    }
}
