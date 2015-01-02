using System;

namespace VendingMachine
{
    internal class Button : IButton
    {
        private readonly Action m_ButtonAction;

        public Button(Action buttonAction)
        {
            m_ButtonAction = buttonAction;
        }

        public void Press()
        {
            m_ButtonAction();
        }
    }
}