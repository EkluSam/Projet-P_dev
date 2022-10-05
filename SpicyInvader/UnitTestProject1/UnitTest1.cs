using System;
using SpicyInvader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Teste si le menu existe
        [TestMethod]
        public void TestMethod1()
        {
            Menu testMenu = new Menu();

            Assert.IsNotNull(testMenu,"n'est pas nulle");
        }

        // Un mur se prend un laser et perds des HP
        [TestMethod]
        public void TestMethod2()
        {
            Wall firstWall = new Wall();

            firstWall.Hp--;

            Assert.AreEqual(4,firstWall.Hp);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Bullet bullet = new Bullet();
            bullet.Y += 7

        }
    }
}
