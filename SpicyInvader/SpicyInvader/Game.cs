// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe game qui est utilisée pour 
// gérer une partie
// ---------------------------------------------
using System;

namespace SpicyInvader
{
    public class Game
    {       
        /// <summary>
        /// Difficulté de la partie
        /// </summary>
        private int _difficulty;
        /// <summary>
        /// Getter setter de la difficulté de la partie
        /// </summary>
        public int Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; }
        }
        /// <summary>
        /// Vie du joueur. 3 vies au debut
        /// </summary>
        private byte _playerLife = 3;
        /// <summary>
        /// Getter  setter de la vie du joueur
        /// </summary>
        public byte PlayerLife
        {
            get { return _playerLife; }
            private set { _playerLife = value; }
        }

        /// <summary>
        /// Score du joueur
        /// </summary>
        private int _playerScore = 0;
        /// <summary>
        /// Getter setter du score du joueur
        /// </summary>
        public int PlayerScore
        {
            get { return _playerScore; }
            private set { _playerScore = value; }
        }

        /// <summary>
        /// Objet du vaisseau
        /// </summary>
        private RocketShip _ship = new RocketShip();
        /// <summary>
        /// Objet des aliens
        /// </summary>
        private Squad _aliens = new Squad();
        /// <summary>
        /// Objet des lazers
        /// </summary>
        private Magazine _bullets = new Magazine();
        /// <summary>
        /// Objet menu
        /// </summary>
        private Menu _menus = new Menu();
        /// <summary>
        /// Objet des murs
        /// </summary>
        private Protection _walls = new Protection();
        
       

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
      
            int shipStartX = 57; 
            int shipStartY = 44;
            int fps = 0;
            int counterFps = 0;

            _ship.DrawRocketShip(shipStartX, shipStartY);

            // Change la difficulté (vitesse des aliens)
            if(this._difficulty == 2)
            {
                fps = 80;
            }
            else
            {
                fps = 200;
            }

            _walls.DrawAllWalls();
            // Boucle de la partie
            while (true)
            {
                _ship.DrawRocketShip(_ship.X, _ship.Y);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(playerName);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                // Les "frames" du jeu, en gros le moment où les aliens se déplacent
                if (counterFps == fps)
                {
                    counterFps = 0;
                    _aliens.areAliensDead();
                    if (_playerLife <= 0)
                    {
                        break;
                    }
                    _bullets.MoveAllBullets();                
                    CheckBulletCollision(_aliens,_bullets,_walls);                   
                    if(_aliens.IsGameOver())
                    {
                        break;
                    }                    

                    _aliens.MoveAllAliens();

                }
                // Le tir des aliens
                _aliens.VerifyShootingCooldown(_bullets,_difficulty);

                Console.SetCursorPosition(0, 3);

                this.DisplayHearts(_playerLife);
                this.DisplayScore(_playerScore);

                // Vérifie les inputs de l'utilisateur sans ralentir le jeu
                if (Console.KeyAvailable)
                {
                    
                    ConsoleKeyInfo Key = Console.ReadKey(true);
                    // Mouvement droite du vaisseau
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
                    // Mouvement gauche du vaisseau
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
                        _bullets.CreateLaser(_ship.X+3,_ship.Y-1,-1,true);
                    }
                    //Menu Pause
                    if (Key.Key == ConsoleKey.P)
                    {
                        _menus.DisplayPauseMenu();
                    }
                }
                counterFps++;
            }
            // TODO : faire un fichier pour les score (GPT3)
            _menus.DisplayGameOverMenu(_playerScore);

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
        /// <summary>
        /// Méthode qui affiche le score du joueur
        /// </summary>
        /// <param name="playerScore">Variable du score du joueur</param>
        public void DisplayScore(int playerScore)
        {
            Console.SetCursorPosition(0, 3);
            Console.Write("Score : " + playerScore);
        }
        /// <summary>
        /// Méthode qui gère toutes les collisions :
        /// lazer du vaisseau qui touche un alien ou le mur du haut
        /// lazer aliens qui touche le vaisseau ou le mur du bas 
        /// TODO : lazers aliens qui touche des murs
        /// TODO : lazers du vaisseau qui  touche les murs
        /// </summary>
        /// <param name="squad">L'objet des aliens</param>
        /// <param name="lasers">L'objets des lazers</param>
        public void CheckBulletCollision(Squad squad, Magazine lasers, Protection walls)
        {
            
            foreach (Laser bullet in lasers.Lasers)
            {               
                
                // Limite du haut
                if(bullet.Y <= 10)
                {
                    bullet.EraseBullet();
                    lasers.Lasers.Remove(bullet);
                    lasers.CurrentShipLasers--;
                    return;
                }
                // Limite du bas
                if(bullet.Y >= 48)
                {
                    bullet.EraseBullet();
                    lasers.Lasers.Remove(bullet);
                    lasers.CurrentAlienLasers--;
                    return;
                }
                // quand le vaisseau est touché
                if(bullet.X >= _ship.X && bullet.X < _ship.X+7 && bullet.Y >= _ship.Y && bullet.Y <= _ship.Y +4)
                {
                    bullet.EraseBullet();
                    lasers.Lasers.Remove(bullet);
                    lasers.CurrentAlienLasers--;
                    _playerLife--;
                    return;
                }
                // boucle qui vérifie pour chaque alien si il est touché
                foreach (Alien alien in squad.Aliens)
                {
                    if (alien.Alive)
                    {
                        // si la balle touche l'alien et qu'elle a été tirer par le joueur, l'alien meurt
                        if (bullet.X >= alien.X && bullet.X < alien.X+10 && bullet.Y <= alien.Y+4 && bullet.Y >= alien.Y && bullet.SpeedY == -1)
                        {                           
                            alien.Alive = false;
                            alien.EraseAlien();                            
                            bullet.EraseBullet();
                            lasers.Lasers.Remove(bullet);
                            lasers.CurrentShipLasers--;
                            _playerScore += 150;
                            return;
                        }
                    }
                    else
                    {

                    }
                }
                // Si un mur est touché
                foreach (Wall wall in walls.Walls)
                {
                    if (wall.Alive)
                    {
                        if(bullet.Y == wall.Y && bullet.X == wall.X)
                        {
                            
                            bullet.EraseBullet();
                            // Baisse le compteur en fonction du tireur du laser
                            if (bullet.Friendly)
                            {
                                lasers.CurrentShipLasers--;
                            }
                            else
                            {
                                lasers.CurrentAlienLasers--;
                            }
                            
                            lasers.Lasers.Remove(bullet);
                            
                            // Baisse les hp du groupe du mur
                            foreach (Wall groupwall in walls.Walls)
                            {
                                if (groupwall.GroupNumber == wall.GroupNumber)
                                {
                                    groupwall.Hp--;
                                    if (groupwall.Hp <= 0)
                                    {
                                        groupwall.Alive = false;
                                        groupwall.EraseWall();
                                    }
                                    else
                                    {
                                        groupwall.DrawWall();
                                    }
                                }
                            }
                            return;
                        }
                    }
                }
            }
        }
    }
}
