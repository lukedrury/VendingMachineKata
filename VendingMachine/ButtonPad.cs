using System;

namespace VendingMachine
{
    public class ButtonPad
    {
        private readonly Selection m_Selection = new Selection();
        public readonly IButton One;
        public readonly IButton Two;
        public readonly IButton Three;
        public readonly IButton Four;
        public readonly IButton Five;
        public readonly IButton Six;
        public readonly IButton ClearSelection;
        public readonly IButton ClearTransaction;

        public ButtonPad(Action clearTransaction, Action selectionChangedAction)
        {
            One = new Button(() => {m_Selection.AddToSelection(1); selectionChangedAction();});
            Two = new Button(() => {m_Selection.AddToSelection(2); selectionChangedAction();});
            Three = new Button(() => {m_Selection.AddToSelection(3); selectionChangedAction();});
            Four = new Button(() => {m_Selection.AddToSelection(4); selectionChangedAction();});
            Five = new Button(() => {m_Selection.AddToSelection(5); selectionChangedAction();});
            Six = new Button(() => {m_Selection.AddToSelection(6); selectionChangedAction();});
            ClearSelection = new Button(() => {m_Selection.Clear(); selectionChangedAction();});
            ClearTransaction = new Button(clearTransaction);
        }

        public string GetCurrentSelection()
        {
            return m_Selection.CurrentSelection;
        }

    }
}