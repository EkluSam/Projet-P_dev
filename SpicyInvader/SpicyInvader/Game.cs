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

        private RocketShip _ship = new RocketShip();
        private Squad _aliens = new Squad();
        private Magazine _bullets = new Magazine();
        private Menu _menus = new Menu();

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
            int yPos = 44;
            int fps = 0;
            int counterFps = 0;
            int counterBullet = 0;

            _ship.DrawRocketShip(xPos, yPos);

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
                    if (_aliens.isGameWon())
                    {
                        _isWon = true;
                        break;
                    }
                    if (_playerLife <= 0)
                    {
                        _isWon = false;
                        break;
                    }
                    _bullets.MoveAllBullets();                
                    CheckBulletCollision(_aliens,_bullets);                   
                    if(_aliens.IsGameOver())
                    {
                        _isWon = false;
                        break;
                    }                    
                    else if (_isWon)
                    {
                        break;
                    }
                    _aliens.MoveAllAliens();

                }
                _aliens.VerifyShootingCooldown(_bullets,_difficulty);

                Console.SetCursorPosition(0, 3);

                this.DisplayHearts(_playerLife);
                this.DisplayScore(_playerScore);

                if (Console.KeyAvailable)
                {
                    // Mouvements du vaisseau
                    ConsoleKeyInfo Key = Console.ReadKey(true);
                    if (Key.Key == ConsoleKey.RightArrow)
                    {
                        if (_ship.X != 112)
                        {
                            _ship.EraseRocketShip(_ship.X, _ship.Y);
                            _ship.X += 1;
                            _ship.DrawRocketShip(_ship.X, _ship.Y);
                        }
                        else
                        {
                           
                        }
                    }
                    if (Key.Key == ConsoleKey.LeftArrow)
                    {
                        if (_ship.X != 4)
                        {
                            _ship.EraseRocketShip(_ship.X, _ship.Y);
                            _ship.X -= 1;
                            _ship.DrawRocketShip(_ship.X, _ship.Y);
                        }
                        else
                        {

                        }
                    }

                    // Tirer avec le vaisseau
                    if (Key.Key == ConsoleKey.UpArrow)
                    {
                        _bullets.CreateBullet(_ship.X+3,_ship.Y-1,-1);
                    }
                    else
                    {

                    }
                }
                counterFps++;
                counterBullet++;

            }

            // Fin du jeu vérifie si le joueur à gagné la partie
            if (_isWon)
            {
                
            }
            else
            {
                _menus.DisplayGameOverMenu(_playerScore);
            }
        }
        /// <summary>
        /// Méthode qui dessine le nombre de vie (en coeurs) du joueurs
        /// </summary>
        /// <param name="playerLife">nombre de vie du joueur</param>
        public void DisplayHearts(byte playerLife)
        {
            byte index = 0;
            string hearts = "♥♥♥";  
            char empty = ' ';
            Console.SetCursorPosition(110, 3);
            foreach (char c in hearts)
            {
                if (index >= _playerLife)
                {
                   Console.Write(empty);
                }
                else
                {
                    Console.Write(c);
                }
                index++;
            }
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
                if(bullet.Y >= 48)
                {
                    bullet.EraseBullet();
                    bullets.Bullets.Remove(bullet);
                    bullets.CurrentBullets--;
                    return;
                }
                if(bullet.X >= _ship.X && bullet.X < _ship.X+7 && bullet.Y >= _ship.Y && bullet.Y <= _ship.Y +4)
                {
                    bullet.EraseBullet();
                    bullets.Bullets.Remove(bullet);
                    bullets.CurrentBullets--;
                    _playerLife--;
                    return;
                }
                // quand un alien est touché
                foreach (Alien alien in squad.Aliens)
                {
                    if (alien.Alive)
                    {
                        // si la balle touche un alien et qu'elle a été tirer par le joueur, l'alien meurt
                        if (bullet.X > alien.X && bullet.X < alien.X+10 && bullet.Y <= alien.Y+5 && bullet.Y >= alien.Y && bullet.SpeedY == -1)
                        {                           
                            alien.Alive = false;
                            alien.EraseAlien();                            
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
