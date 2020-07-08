using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ShootGame.ShootLogic sl = new ShootGame.ShootLogic();

            Assert.AreNotEqual(sl.FireAwayChance, 3);

        }

        [TestMethod]
        public void TestMethod2()
        {
            ShootGame.ShootLogic sl = new ShootGame.ShootLogic();

            Assert.AreEqual(sl.Bullet, 7);

        }
    }
}
