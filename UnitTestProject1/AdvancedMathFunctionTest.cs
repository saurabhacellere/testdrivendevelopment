using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AdvancedMathFunctionTest
    {
        [TestMethod]
        public void TestDivision()
        {
            var mathLibrary = new Exercise.MathLibrary();

            int expected = 21;
            int actual = mathLibrary.Division(42, 2);

            Assert.AreEqual(expected, actual, "The expected value did not match actual value");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {

            var mathLibrary = new Exercise.MathLibrary();

            int actual = mathLibrary.Division(42, 0);
            Assert.Fail("An exception should have been thrown");

        }

        [TestMethod]
        public void TestDivisionByZeroException()
        {
            try
            {
                var mathLibrary = new Exercise.MathLibrary();

                int actual = mathLibrary.Division(42, 0);
                Assert.Fail("An exception should have been thrown");
            }
            catch(DivideByZeroException)
            {
                // Assert.Pass
            }
            catch(Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message));
            }
        }
    }
}
