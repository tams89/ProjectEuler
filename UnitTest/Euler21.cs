using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class Euler21
    {
        [TestMethod]
        public void Euler21_220()
        {
            const int expected = 284;
            var calculated = Euler.Euler21.d(220);
            Assert.AreEqual(expected, calculated);
        }

        [TestMethod]
        public void Euler21_284()
        {
            const int expected = 220;
            var calculated = Euler.Euler21.d(284);
            Assert.AreEqual(expected, calculated);
        }
    }
}