using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Selection
    {
        private readonly List<int> m_CurrentSelection = new List<int>();
        private const int c_SelectionLength = 3;

        public void AddToSelection(int number)
        {
            m_CurrentSelection.Add(number);
            TruncateToLength(c_SelectionLength);
        }

        public string CurrentSelection
        {
            get
            {
                var s = new StringBuilder();
                m_CurrentSelection.ForEach(i => s.Append(i));
                return s.ToString();
            }
        }

        private void TruncateToLength(int length)
        {
            while (m_CurrentSelection.Count > length)
            {
                m_CurrentSelection.RemoveAt(0);
            }
        }

        public void Clear()
        {
            m_CurrentSelection.Clear();
        }
    }
}