using NUnit.Framework;

namespace VendingMachine
{
    public class SelectionTests
    {
        [Test]
        public void NewSelectionShouldBeEmpty()
        {
            var selection = new Selection();
            Assert.That(selection.CurrentSelection, Is.EqualTo(""));
        }

        [Test]
        public void OneNumberShouldShowInSelection()
        {
            var selection = new Selection();
            selection.AddToSelection(3);
            Assert.That(selection.CurrentSelection, Is.EqualTo("3"));
            
        }
    }
}