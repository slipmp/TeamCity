using System;
using NUnit.Framework;

namespace TeamCityWeb.Tests
{
    [TestFixture]
    public class TeamCityTests
    {
        [Test]
        public void MyTestMethod()
        {
            int i=10;

            Assert.AreEqual(10, i);
        }
    }
}
