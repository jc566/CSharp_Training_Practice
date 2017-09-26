using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Calculator_Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        //instantiate the variables
        float num1, num2, actual, expected;

        //make new instances of the classes
        addition add = new addition();
        subtraction subtract = new subtraction();
        multiplication multiply = new multiplication();
        division divide = new division();

        Program ourProgram = new Program();
        [TestMethod]
        public void testMultiplication()
        {
            num1 = 5;
            num2 = 2;

            expected = 10;

            actual = multiply.multiply(5, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testAddition()
        {
            num1 = 8;
            num2 = 9;

            expected = 17;

            actual = add.add(num1, num2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testSubtraction()
        {
            num1 = 15;
            num2 = 10;

            expected = 5;

            actual = subtract.subtract(num1, num2);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void testDivision()
        {
            num1 = 20;
            num2 = 2;

            expected = 10;



            actual = divide.Divide(num1, num2);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void testDivisionFail()
        {
            num1 = 20;
            num2 = 2;



            expected = 9;

            actual = divide.Divide(num1, num2);
            Assert.AreNotEqual(expected, actual);
        }



    }
}
