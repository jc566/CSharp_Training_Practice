using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace UnitTestProject1
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [TestMethod]

            public double CalculateArea(int r)
            {
                 return 3.14 * r * r;
            }

    }
}

