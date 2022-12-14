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

        private int _difficulty;

        public int Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; }
        }

        private bool _isWon = false;

        private byte _playerLife = 3;

        private int _playerScore = 0;

        RocketShip Ship = new RocketShip();
        Squad aliens = new Squad();
        Magazine bullets = new Magazine();
        Menu menus = new Menu();

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



            int xPos = 57; 
            int yPos = 40;
            int fps = 0;
            int counterFps = 0;
            int alienBulletCooldown = 0;
            

            Ship.DrawRocketShip(xPos, yPos);

            // Change la difficulté (vitesse des aliens)
            if(this._difficulty == 2)
            {
                fps = 200;
            }
            else
            {
                fps = 800;
            }

            while (true)
            {


                

                if (counterFps == fps)
                {
                    counterFps = 0;
                    bullets.MoveAllBullets();
                    CheckBulletCollision(aliens,bullets);                   
                    if(aliens.IsGameOver())
                    {
                        _isWon = false;
                        break;
                    }                    
                    else if (_isWon)
                    {
                        break;
                    }
                    aliens.MoveAllAliens();

                }
                aliens.VerifyShootingCooldown(bullets,_difficulty);

                Console.SetCursorPosition(0, 3);

                this.DisplayHearts(_playerLife);
                this.DisplayScore(_playerScore);

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
                        bullets.CreateBullet(Ship.X+3,Ship.Y-1,-1);
                    }
                    else
                    {

                    }
                }
                counterFps++;
                alienBulletCooldown++;
            }

            // Fin du jeu vérifie si le joueur à gagné la partie
            if (_isWon)
            {
                
            }
            else
            {
                menus.DisplayGameOverMenu(_playerScore);
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
            Console.SetCursorPosition(0, 3);
            Console.Write("Score : " + playerScore);
        }

        public void CheckBulletCollision(Squad squad, Magazine bullets)
        {
            
            foreach (Bullet bullet in bullets.Bullets)
            {
                if(bullet.Y <= 10)
                {
                    bullet.EraseBullet();
                    bullets.Bullets.Remove(bullet);
                    bullets.CurrentBullets--;
                    return;
                }
                if(bullet.Y >= 40)
                {
                    bullet.EraseBullet();
                    bullets.Bullets.Remove(bullet);
                    bullets.CurrentBullets--;
                    return;
                }
                else
                {
                    
                }
                foreach (Alien alien in squad.Aliens)
                {
                    if (alien.Alive)
                    {
                        if (bullet.X > alien.X && bullet.X < alien.X+10 && bullet.Y <= alien.Y+5 && bullet.Y >= alien.Y)
                        {
                            alien.Alive = false;
                            alien.EraseAlien();
                            squad.Aliens.Remove(alien);
                            bullet.EraseBullet();
                            bullets.Bullets.Remove(bullet);
                            _playerScore += 150;
                            if (squad.Aliens.Count == 0)
                            {
                                _isWon = true;
                            }
                            return;
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
