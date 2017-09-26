using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HelloTestDevOPs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            Assert.AreEqual(p.GetNum(), 5);

        }
    }
}
