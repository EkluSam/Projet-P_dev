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

        // Si un laser touche un alien
        [TestMethod]
        public void TestMethod3()
        {
            Alien firstAlien = new Alien(3,3);
            Bullet shipBullet = new Bullet();
            shipBullet.Y += 7;

            Assert.AreEqual(shipBullet.Y, firstAlien.Y);
        }

        // Si un laser touche le vaisseau
        [TestMethod]
        public void TestMethod4()
        {
            Bullet firstAlienBullet = new Bullet();
            RocketShip ship = new RocketShip();

            firstAlienBullet.Y += 7;
            Assert.AreEqual(firstAlienBullet.Y, ship);
        }
    }
}
