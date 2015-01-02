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

        public ButtonPad()
        {
            One = new Button(() => m_Selection.AddToSelection(1));
            Two = new Button(() => m_Selection.AddToSelection(2));
            Three = new Button(() => m_Selection.AddToSelection(3));
            Four = new Button(() => m_Selection.AddToSelection(4));
            Five = new Button(() => m_Selection.AddToSelection(5));
            Six = new Button(() => m_Selection.AddToSelection(6));
            ClearSelection = new Button(() => m_Selection.Clear());
        }

        public string GetCurrentSelection()
        {
            return m_Selection.CurrentSelection;
        }

    }
}