using Microsoft.VisualStudio.TestTools.UnitTesting;
using InversionOfControl.Console;

namespace InversionOfControl.UnitTests
{
    [TestClass]
    public class StronglyCoupledTests
    {
        [TestMethod]
        public void DoSomeWork_None_ReturnNotExpectedString()
        {
            StronglyCoupled lc = new StronglyCoupled();

            string res = lc.DoSomeWork();

            Assert.AreNotEqual(res, "Pretend to work.");
        }
    }
}
