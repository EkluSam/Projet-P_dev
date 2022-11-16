using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Alien
    {

        /// <summary>
        /// Symbol de l'alien
        /// </summary>
        private static string[] _alien = new string[2]
        {
            "██████o███o██████",
            "████████u████████",
        };

        /// <summary>
        /// Vide fait pour effacer l'alien
        /// </summary>
        private static string[] _void = new string[2]
        {
            "     ",
            "     ",
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

        /// <summary>
        /// Méthode qui dessine le vaisseau à la position donné
        /// </summary>
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
        public void DrawAlien(int x, int y)
        {
            this.X = x;
            this.Y = y;
            for (int i = 0; i < _alien.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(_alien[i]);
                y++;
            }
        }
        /// <summary>
        /// Méthode qui efface le vaisseau à la position donné
        /// </summary>
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
        public void EraseAlien(int x, int y)
        {
            for (int i = 0; i < _alien.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(_void[i]);
                y++;
            }
        }
    }
}
