using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Threading_Example;
using System.Diagnostics.CodeAnalysis;


namespace UnitTestProject1
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        MyThread niceThread = new MyThread();
        float actual, expected;
        [TestMethod]
        public void TestaddTwoNums()
        {
            float num1 = 1, num2 = 2;

            float expected = 42;
            float actual = niceThread.addTwoNums(num1, num2); ;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testdoAlotMore()
        {
            float num1 = 1, num2 = 2, num3 = 3, num4 = 4, num5 = 5;

            expected = 500;
            actual = niceThread.doALotMore(num1, num2, num3, num4, num5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testdoEvenMore()
        {
            float num1 = 1, num2 = 2, num3 = 3, num4 = 4, num5 = 5;

            expected = 75;
            actual = niceThread.doEvenMore(num1, num2, num3, num4, num5);

            Assert.AreEqual(expected, actual);
        }
    }
}
