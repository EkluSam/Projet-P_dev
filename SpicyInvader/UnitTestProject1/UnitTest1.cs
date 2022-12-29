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
            // Arrange 
            Menu testMenu = new Menu();

            // Act

            // Assert
            Assert.IsNotNull(testMenu,"n'est pas nulle");
        }

        // Un mur se prend un laser et perds des HP
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            Wall testWall = new Wall(x:3,y:20,groupNumber:0);
            Laser testLaser = new Laser();
            testLaser.X = 3;
            testLaser.Y = 20;

            // Act
            if(testLaser.X == testWall.X && testLaser.Y == testWall.Y)
            {
                testWall.Hp--;
            }

            // Assert
            Assert.AreEqual(2,testWall.Hp);
        }

        // Si un laser est à la même position q'un alien
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            Alien testAlien = new Alien(3,3);
            Laser testLaser = new Laser();
            testLaser.X = 3;
            testLaser.Y = 3;
            bool hit = false;
            // Act
            if (testAlien.X == testLaser.X && testAlien.Y == testLaser.Y)
            {
                 hit = true;
            }
            // Assert
            Assert.IsTrue(hit);
        }

        // Si un laser touche le vaisseau
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            Laser testAlienLaser = new Laser();
            RocketShip testShip = new RocketShip();
            testAlienLaser.Y = 7;
            testAlienLaser.X = 20;
            testShip.X = 20;
            testShip.Y = 7;
            bool hit = false;

            // Act 
            if (testShip.X == testAlienLaser.X && testShip.Y == testAlienLaser.Y)
            {
                hit = true;
            }

            // Assert
            Assert.IsTrue(hit);
        }
    }
}
