using System.Text;

namespace VendingMachine
{
    public class Selection
    {
        private readonly StringBuilder m_CurrentSelection = new StringBuilder();

        public void AddToSelection(int number)
        {
            m_CurrentSelection.Append(number);
        }

        public string CurrentSelection
        {
            get { return m_CurrentSelection.ToString(); }
        }
    }
}