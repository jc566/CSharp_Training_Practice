using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Threading_Example;


namespace Threading_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaddTwoNums()
        {
            float num1 = 1, num2 = 2;


            MyThread niceThread = new MyThread();



            float expected = 42;
            float actual = niceThread.addTwoNums(num1, num2); ;

            Assert.AreEqual(expected, actual);

        }
    }
}
