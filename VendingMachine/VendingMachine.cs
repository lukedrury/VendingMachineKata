using System;

namespace VendingMachine
{
    class VendingMachine
    {
        public IDisplay Display { get { return m_Display; } }
        public ButtonPad ButtonPad { get { return m_ButtonPad; } }
        public CoinInHopper CoinSlot { get { return m_CoinSlot; } }

        public VendingMachine()
        {
            m_Display = new Display{Row1 = c_Ready};
            m_ButtonPad = new ButtonPad(OnClearTransaction, OnSelectionChanged);
            m_CoinSlot = new CoinInHopper(OnCoinInserted);
            OnSelectionChanged();
        }

        private void OnCoinInserted()
        {
            m_Display.Row2 = String.Format("{0}p", m_CoinSlot.TotalInserted);
        }

        private void OnSelectionChanged()
        {
            var currentSelection = m_ButtonPad.GetCurrentSelection();
            m_Display.Row1 = String.IsNullOrEmpty(currentSelection) ? c_Ready : currentSelection;
        }

        private void OnClearTransaction()
        {
        }

        private const string c_Ready = "Ready";
        private readonly Display m_Display;
        private readonly ButtonPad m_ButtonPad;
        private readonly CoinInHopper m_CoinSlot;
    }
}