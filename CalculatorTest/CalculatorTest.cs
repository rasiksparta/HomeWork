using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        private CalculatorFunction calculator;
        [TestInitialize]
        public void Init()
        {
            calculator = new CalculatorFunction();
        }

        [TestCleanup]
        public void Clean()
        {
            calculator = null;
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
            Assert.AreEqual(Double.PositiveInfinity, calculator.Divide(1, 0));
            Assert.AreEqual(Double.NegativeInfinity, calculator.Divide(-1, 0));
            //Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(1,0));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(12, calculator.Multiply(6, 2));
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(13, calculator.Add(8, 5));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(12, calculator.Subtract(15, 3));
        }
    }
}
