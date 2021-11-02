using Microsoft.VisualStudio.TestTools.UnitTesting;
using InversionOfControl.Console;

namespace InversionOfControl.UnitTests
{
    [TestClass]
    public class LosslyCoupledTests
    {
        private IWork mockWork { get; set;}

        [TestInitialize]
        public void InitializeTests()
        {
            mockWork = new MockWork();
        }

        [TestMethod]
        public void DoSomeWork_None_ReturnExpectedString()
        {
            LosslyCoupled lc = new LosslyCoupled(mockWork);

            string res = lc.DoSomeWork();

            Assert.AreEqual(res, "Pretend to work.");
        }
    }
}
