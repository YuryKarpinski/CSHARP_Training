using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10, b = 2;
            Calc calculator = new Calc();
            Assert.AreEqual(calculator.Summ(a, b), 12);
            Assert.AreEqual(calculator.Difference(a, b), 8);
            Assert.AreEqual(calculator.Multiply(a, b), 20);
            Assert.AreEqual(calculator.Division(a, b), 5.0);
        }
    }
}
