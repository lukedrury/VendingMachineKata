namespace VendingMachine
{
    public class ButtonPad
    {
        private readonly Selection m_Selection = new Selection();

        public string GetCurrentSelection()
        {
            return m_Selection.CurrentSelection;
        }

    }
}