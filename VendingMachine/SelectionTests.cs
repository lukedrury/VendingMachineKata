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

        [Test]
        public void ThreeNumbersShouldShowInSelection()
        {
            var selection = new Selection();
            selection.AddToSelection(3);
            selection.AddToSelection(5);
            selection.AddToSelection(7);
            Assert.That(selection.CurrentSelection, Is.EqualTo("357"));

        }

        [Test]
        public void FourNumberShouldShowLastThreeInSelection()
        {
            var selection = new Selection();
            selection.AddToSelection(3);
            selection.AddToSelection(5);
            selection.AddToSelection(7);
            selection.AddToSelection(9);
            Assert.That(selection.CurrentSelection, Is.EqualTo("579")); 
        }

        [Test]
        public void ResetShouldSetSelectionBackToEmpty()
        {
            var selection = new Selection();
            selection.AddToSelection(3);
            selection.Clear();
            Assert.That(selection.CurrentSelection, Is.EqualTo(""));
        }
    }
}