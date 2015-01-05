using System;

namespace VendingMachine
{
    class VendingMachine
    {
        private readonly Display m_Display;
        private readonly ButtonPad m_ButtonPad;

        public IDisplay Display { get { return m_Display; } }
        public ButtonPad ButtonPad { get { return m_ButtonPad; } }

        public VendingMachine()
        {
            m_Display = new Display();
            m_ButtonPad = new ButtonPad(Reset, OnSelectionChanged);
            OnSelectionChanged();
        }

        private void OnSelectionChanged()
        {
            var currentSelection = m_ButtonPad.GetCurrentSelection();
            m_Display.Row1 = String.IsNullOrEmpty(currentSelection) ? "Ready" : currentSelection;
        }

        private void Reset()
        {
        }
    }
}