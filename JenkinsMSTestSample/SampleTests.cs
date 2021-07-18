using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsMSTestSample
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            Assert.AreEqual(1, a);
        }
    }
}
