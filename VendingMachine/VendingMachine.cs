using System;

namespace VendingMachine
{
    class VendingMachine
    {
        private readonly Display m_Display = new Display();
        public IDisplay Display { get { return m_Display; } }

        public VendingMachine()
        {
            m_Display.Row1 = "Ready";
        }
    }
}