using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using verbose_test;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Calc cal = new Calc();
            int a = 1;
            int b = 2;

            var result = cal.Add(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}
