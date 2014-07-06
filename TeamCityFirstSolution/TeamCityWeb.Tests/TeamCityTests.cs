using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamCityWeb.Tests
{
    [TestClass]
    public class TeamCityTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            int i=10;

            Assert.AreEqual(11, i);
        }
    }
}
