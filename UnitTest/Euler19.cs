using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class Euler19
    {
        [TestMethod]
        public void NumberOfDaysInYear()
        {
            const int answer = 173;
            var calculated = Euler.Euler19.answer(1900, 2000);
            Assert.AreEqual(answer, calculated);
        }
    }
}