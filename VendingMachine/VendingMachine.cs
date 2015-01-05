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
            m_Display = new Display {Row1 = "Ready"};
            m_ButtonPad = new ButtonPad(Reset, OnSelectionChanged);
        }

        private void OnSelectionChanged()
        {
            m_Display.Row1 = m_ButtonPad.GetCurrentSelection();
        }

        private void Reset()
        {
        }
    }
}