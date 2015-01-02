using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VendingMachine
{

    public class ButtonPadTests
    {
        [Test]
        public void ShouldStartWithNoSelection()
        {
            var buttonPad = new ButtonPad();
            Assert.That(buttonPad.GetCurrentSelection(), Is.EqualTo(""));
        }
    }
}
