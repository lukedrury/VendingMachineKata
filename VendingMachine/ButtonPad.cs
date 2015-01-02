using System;

namespace VendingMachine
{
    public class ButtonPad
    {
        private readonly Selection m_Selection = new Selection();
        public readonly IButton One;

        public interface IButton
        {
            void Press();
        }

        private class Button : IButton
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

        public ButtonPad()
        {
            One = new Button(() => m_Selection.AddToSelection(1));
        }

        public string GetCurrentSelection()
        {
            return m_Selection.CurrentSelection;
        }

    }
}