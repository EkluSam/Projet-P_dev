using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpicyInvader
{
    public class Game
    {
        const int GAME_WIDTH = 120;

        private int difficulty;

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        RocketShip Ship = new RocketShip();
        Squad aliens = new Squad();
        Magazine bullets = new Magazine();

        /// <summary>
        /// Méthode PLAY qui lance une partie de Space Invader
        /// </summary>
        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(25,7);
            Console.Write("TON PSEUDO ? : ");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(playerName);                               
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            bool isWon = false;
            byte playerLife = 3;
            int playerScore = 0;
            int xPos = 57; 
            int yPos = 40;
            int fps = 0;
            int counter = 0;
            

            Ship.DrawRocketShip(xPos, yPos);

            // Change la difficulté (vitesse des aliens)
            if(this.difficulty == 2)
            {
                fps = 200;
            }
            else
            {
                fps = 800;
            }

            while (true)
            {

                if (counter == fps)
                {
                    counter = 0;
                    bullets.MoveAllBullets();
                    CheckBulletCollision(aliens,bullets);

                    aliens.MoveAllAliens();
                    if(aliens.isGameOver())
                    {
                        isWon = false;
                        break;
                    }                    
                    
                }

                Console.SetCursorPosition(0, 3);
                Console.WriteLine("SCORE : " + playerScore);

                this.DisplayHearts(playerLife);

                if (Console.KeyAvailable)
                {
                    // Mouvements du vaisseau
                    ConsoleKeyInfo Key = Console.ReadKey(true);
                    if (Key.Key == ConsoleKey.RightArrow)
                    {
                        if (Ship.X != 112)
                        {
                            Ship.EraseRocketShip(Ship.X, Ship.Y);
                            Ship.X += 1;
                            Ship.DrawRocketShip(Ship.X, Ship.Y);
                        }
                        else
                        {

                        }
                    }
                    if (Key.Key == ConsoleKey.LeftArrow)
                    {
                        if (Ship.X != 4)
                        {
                            Ship.EraseRocketShip(Ship.X, Ship.Y);
                            Ship.X -= 1;
                            Ship.DrawRocketShip(Ship.X, Ship.Y);
                        }
                        else
                        {

                        }
                    }

                    // Tirer avec le vaisseau
                    if (Key.Key == ConsoleKey.UpArrow)
                    {
                        bullets.CreateBullet(Ship.X,Ship.Y-1,aliens);
                    }
                }
                counter++;
            }

            // Fin du jeu vérifie si le joueur à gagné la partie
            if (isWon)
            {

            }
            else
            {

            }
        }
        /// <summary>
        /// Méthode qui dessine le nombre de vie (en coeurs) du joueurs
        /// </summary>
        /// <param name="playerLife">nombre de vie du joueur</param>
        public void DisplayHearts(byte playerLife)
        {
            char heart = '♥';
            string hearts = "";           
            for (int i = 0; i < playerLife; i++)
            {
                hearts += heart;
            }
            Console.SetCursorPosition(110, 3);
            Console.Write("Vies : " + hearts);
        }

        public void DisplayScore(int playerScore)
        {

        }

        public void CheckBulletCollision(Squad squad, Magazine bullets)
        {
            foreach (Bullet bullet in bullets.Bullets)
            {
                foreach (Alien alien in squad.Aliens)
                {
                    if (alien.Alive)
                    {
                        if (bullet.X == alien.X && bullet.Y == alien.Y || bullet.Y == 10)
                        {

                        }
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
