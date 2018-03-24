using System;
using Initial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"Data\Data.xml", "Shaft", DataAccessMethod.Sequential)]
        public void TestInt()
        {
            Mine mine1 = new Mine();
            int a = (int)TestContext.DataRow[0];
            //int b = (int)TestContext.DataRow[1];
            //int exp = (int)TestContext.DataRow[2];
            Assert.AreEqual(mine1.daj(a), a+5);
        }
        [TestMethod]
        public void TestString()
        {
            Mine toplel = new Mine();
            StringAssert.Contains(toplel.poloncz("nie"), "taknie");
        }

    }
}
