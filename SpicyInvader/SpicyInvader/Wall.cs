// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe du Mur
// ---------------------------------------------
using System;
namespace SpicyInvader
{
    public class Wall
    {
        /// <summary>
        /// Symbol du mur
        /// </summary>
        private char _symbol = '▄';

        /// <summary>
        /// Getter setter du symbol du mur
        /// </summary>
        public char Symbol
        {
            get { return _symbol; }
            private set { _symbol = value; }
        }
        /// <summary>
        /// Vide fait pour effacer un mur
        /// </summary>
        private char _void = ' ';
        /// <summary>
        /// Getter setter du vide pour effacer un mur
        /// </summary>
        public char Void
        {
            get { return _void; }
            private set { _void = value; }
        }

        /// <summary>
        /// position x du mur
        /// </summary>
        private int _x;
        /// <summary>
        /// Getter setter de la position x du mur
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// position y du mur
        /// </summary>
        private int _y;
        /// <summary>
        /// getter setter de la postion y du mur
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// hp du mur
        /// </summary>
        private int _hp = 3;
        /// <summary>
        /// Getter setter des hps du mur
        /// </summary>
        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        /// <summary>
        /// booléen vrai ou faux qui détermine si il est en vie ou pas
        /// </summary>
        private bool _alive = true;
        /// <summary>
        /// Getter setter du booléen alive
        /// </summary>
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public Wall(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        /// <summary>
        /// Méthode qui affiche le mur
        /// </summary>
        public void DrawWall()
        {
            int x = this._x;
            int y = this._y;
            Console.SetCursorPosition(x, y);
            
            switch (this._hp)
            {
                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(_symbol);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(_symbol);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_symbol);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            
        }

        /// <summary>
        /// Méthode qui efface le mur
        /// </summary>
        public void EraseWall()
        {
            int x = this._x;
            int y = this._y;

            Console.SetCursorPosition(x,y);
            Console.Write(_void);
        }
    }
}
