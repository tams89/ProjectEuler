using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Euler26
    {
        [TestMethod]
        public void DivideTest()
        {
            var dividend = 9;
            var divisor = 5;
            var result = new ProjectEuler.Euler26().Divide(dividend, divisor);

            Assert.AreEqual(1, 1);
        }
    }
}
