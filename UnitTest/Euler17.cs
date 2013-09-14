using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Euler17Tests
    {
        [TestMethod]
        public void Euler17_0()
        {
            const int testVar = 0;
            const string actual = "zero";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_1()
        {
            const int testVar = 1;
            const string actual = "one";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_11()
        {
            const int testVar = 11;
            const string actual = "eleven";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_87()
        {
            const int testVar = 87;
            const string actual = "eighty seven";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_100()
        {
            const int testVar = 100;
            const string actual = "one hundred";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_111()
        {
            const int testVar = 111;
            const string actual = "one hundred and eleven";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_1000()
        {
            const int testVar = 1000;
            const string actual = "one thousand";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_1111()
        {
            const int testVar = 1111;
            const string actual = "one thousand one hundred and eleven";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_165()
        {
            const int testVar = 165;
            const string actual = "one hundred and sixty five";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_1265()
        {
            const int testVar = 1265;
            const string actual = "one thousand two hundred and sixty five";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }
    }
}