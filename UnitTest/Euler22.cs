using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class Euler22
    {
        [TestMethod]
        public void Answer()
        {
            const int answer = 871198282;
            var calculated = Euler.Euler22.answer;
            Assert.AreEqual(answer, calculated);
        }
    }
}