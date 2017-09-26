using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTestDevOPs
{
    [TestClass]
    public class UnitTest1
    {
        Tester p = new Tester();
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(p.GetNum(), 5);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreNotEqual(p.GetNum(), 6);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(p.Print(), true);
        }



        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreNotEqual(p.Print(), false);
        }


        [TestMethod]
        public void TestMethod5()
        {
            string[] hello = { "ht", "th" };
            Program.Main(hello);
        }
    }
}