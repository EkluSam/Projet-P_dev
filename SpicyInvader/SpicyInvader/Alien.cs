﻿// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe alien
// ---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Position y de l'alien
        /// </summary>
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        private bool _alive = true;

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        private int _mouvementCounter;

        private int _shootCooldown;

        public int ShootCooldown { get { return _shootCooldown; } set { _shootCooldown = value; } }

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

        public int SpeedX
        {
            get { return speedX; }
            set { speedX = value; }
        }

        /// <summary>
        /// Vitesse Y de l'alien
        /// </summary>
        private int speedY = 1;

        public int SpeedY
        {
            get { return speedY; }
            set { speedY = value; }
        }

        /// <summary>
        /// Méthode qui dessine le vaisseau à la position donné
        /// </summary>
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
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
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
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
