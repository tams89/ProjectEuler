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
        public void Euler17_10()
        {
            const int testVar = 10;
            const string actual = "ten";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_80()
        {
            const int testVar = 80;
            const string actual = "eighty";
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
        public void Euler17_55()
        {
            const int testVar = 55;
            const string actual = "fifty five";
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
        public void Euler17_1222()
        {
            const int testVar = 1222;
            const string actual = "one thousand two hundred and twenty two";
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

        [TestMethod]
        public void Euler17_101()
        {
            const int testVar = 101;
            const string actual = "one hundred and one";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_1001()
        {
            const int testVar = 1001;
            const string actual = "one thousand and one";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_200()
        {
            const int testVar = 200;
            const string actual = "two hundred";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_201()
        {
            const int testVar = 201;
            const string actual = "two hundred and one";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_2000()
        {
            const int testVar = 2000;
            const string actual = "two thousand";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_2001()
        {
            const int testVar = 2001;
            const string actual = "two thousand and one";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }

        [TestMethod]
        public void Euler17_222()
        {
            const int testVar = 222;
            const string actual = "two hundred and twenty two";
            var calc = Euler.Euler17.matchNumberToWord(testVar);
            Assert.AreEqual(actual, calc, ignoreCase: true);
        }
    }
}