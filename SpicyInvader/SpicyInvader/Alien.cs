// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe alien
// ---------------------------------------------
using System;
using System.Threading;
namespace SpicyInvader
{
    public class Alien
    {

        /// <summary>
        /// Symbol de l'alien
        /// </summary>
        private static string[] _alien = new string[5]
        {
               "   ▄██▄   ",
               " ▄██████▄ ",
               "███▄██▄███",
               "  ▄▀▄▄▀▄  ",
               " ▀      ▀ ",
        };

        /// <summary>
        /// Symbol de l'alien
        /// </summary>
        private static string[] _alienMoving = new string[5]
        {
               "   ▄██▄   ",
               " ▄██████▄ ",
               "███▄██▄███",
               "  ▄▀  ▀▄  ",
               "   ▀  ▀  ",
        };
        /// <summary>
        /// Vide fait pour effacer l'alien
        /// </summary>
        private static string[] _void = new string[5]
        {
               "          ",
               "          ",
               "          ",
               "          ",
               "          ",
        };

        /// <summary>
        /// Position x de l'alien
        /// </summary>
        private int _x;
        /// <summary>
        /// Getter setter de la position x de l'alien
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Position y de l'alien
        /// </summary>
        private int _y;
        /// <summary>
        /// Getter setter de la positon y de l'alien
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        /// <summary>
        /// booléen pour savoir si l'alien est en vie
        /// </summary>
        private bool _alive = true;
        /// <summary>
        /// Getter setter du booléen pour savoir si l'alien est en vie
        /// </summary>
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }
        /// <summary>
        /// Compteur pour savoir si l'alien est en mouvement
        /// </summary>
        private int _mouvementCounter;

        /// <summary>
        /// cooldown du tir de l'alien
        /// </summary>
        private int _shootCooldown;
        /// <summary>
        /// Getter setter du cooldown du tir de l'alien
        /// </summary>
        public int ShootCooldown {
            get { return _shootCooldown; } 
            set { _shootCooldown = value; } 
        }

        private Random _random = new Random();
        public Alien(int x, int y)
        {
            this._x = x;
            this._y = y;
            Thread.Sleep(5);
            this._shootCooldown = _random.Next(0,25000);
        }

        /// <summary>
        /// Vitesse X de l'alien
        /// </summary>
        private int speedX = 1;
        /// <summary>
        /// Getter setter de la vitesse x de l'alien
        /// </summary>
        public int SpeedX
        {
            get { return speedX; }
            set { speedX = value; }
        }

        /// <summary>
        /// Vitesse Y de l'alien
        /// </summary>
        private int speedY = 1;
        /// <summary>
        /// Getter setter de la vitesse y de l'alien
        /// </summary>
        public int SpeedY
        {
            get { return speedY; }
            set { speedY = value; }
        }

        /// <summary>
        /// Méthode qui dessine le vaisseau à la position donné
        /// </summary>
        public void DrawAlien()
        {
            int x = this._x;
            int y = this._y;

            if (_mouvementCounter > 7)
            {
                for (int i = 0; i < _alien.Length; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(_alienMoving[i]);
                    y++;
                }
                if(_mouvementCounter == 15)
                {
                    _mouvementCounter = 0;
                }
                else
                {
                    _mouvementCounter++;
                }
            }
            else
            {
                for (int i = 0; i < _alien.Length; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(_alien[i]);
                    y++;
                }
                _mouvementCounter++;
            }
            
        }
        /// <summary>
        /// Méthode qui efface le vaisseau à la position donné
        /// </summary>
        public void EraseAlien()
        {
            int x = this._x;
            int y = this._y;
            for (int i = 0; i < _alien.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(_void[i]);
                y++;
            }
        }
    }
}
