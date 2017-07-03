using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BasicMathFunctionTest
    {
        [TestMethod]
        public void AddTest()
        {
            var mathLibrary = new Exercise.MathLibrary();

            int expected = 42;
            int actual = mathLibrary.Add(40, 2);

            Assert.AreEqual(expected, actual, "The expected value did not match actual value");
        }

        [TestMethod]
        public void SubtractTest()
        {
            var mathLibrary = new Exercise.MathLibrary();
            int expected = 1;
            int actual  = mathLibrary.SubtractionNoMinusResult(31, 30);

            Assert.AreEqual(expected, actual, "The expected value did not match actual value");

        }

        [TestMethod]
        [ExpectedException(typeof (Exercise.SubtractionNegativeErrorException))]
        public void SubtractTestNegative()
        {
            var mathLibrary = new Exercise.MathLibrary();
            int actual = mathLibrary.SubtractionNoMinusResult(31, 100);

            Assert.Fail("An exception should have been thrown");

        }
    }
}
