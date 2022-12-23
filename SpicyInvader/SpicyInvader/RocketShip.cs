// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe rocketship pour le vaisseau
// ---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class RocketShip
    {
        /// <summary>
        /// position x du vaisseau
        /// </summary>
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Position y du vaisseau
        /// </summary>
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// tableau de 3 lignes qui dessine le vaisseau
        /// </summary>
        private static string[] _ship = new string[3]
        {
            "   ▲   ",
            "▲█████▲",
            "███████",
        };
        /// <summary>
        /// tableau de 3 lignes rempli de vide pour effacer le vaisseau
        /// </summary>
        private static string[] _void = new string[3]
        {
            "       ",
            "       ",
            "       ",
        };


        public RocketShip()
        {
            
        }

        /// <summary>
        /// Méthode qui dessine le vaisseau à la position donné
        /// </summary>
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
        public void DrawRocketShip(int x, int y)
        {
            this.X = x;
            this.Y = y;         
            for(int i = 0; i < _ship.Length; i++)
            {
                Console.SetCursorPosition(x,y);
                Console.Write(_ship[i]);
                y++;
            }       
        }
        /// <summary>
        /// Méthode qui efface le vaisseau à la position donné
        /// </summary>
        /// <param name="x">position x</param>
        /// <param name="y">position y</param>
        public void EraseRocketShip(int x, int y)
        {
            for (int i = 0; i < _ship.Length; i++)
            {
                Console.SetCursorPosition(x,y);
                Console.Write(_void[i]); 
                y++;
            }
        }
    }
}
