// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe Bullet
// ---------------------------------------------
using System;

namespace SpicyInvader
{
    public class Laser
    {

        /// <summary>
        /// Symbol du laser
        /// </summary>
        private char _symbol = '|';
        /// <summary>
        /// Getter setter du symbol du laser
        /// </summary>
        public char Symbol
        {
            get { return _symbol; }
            private set { _symbol = value; }
        }
        /// <summary>
        /// Vide pour effacer le laser
        /// </summary>
        private char _void = ' ';
        /// <summary>
        /// getter setter d'un vide
        /// </summary>
        public char Void
        {
            get { return _void; }
            private set { _void = value; }
        }
        /// <summary>
        /// Vitesse du laser
        /// </summary>
        private int _speedY;
        /// <summary>
        /// Getter setter de la vitesse du laser
        /// </summary>
        public int SpeedY
        {
            get { return _speedY; }
            private set { _speedY = value; }
        }

        /// <summary>
        /// Position x du laser
        /// </summary>
        private int _x;
        /// <summary>
        /// Getter setter de la position x 
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Position y du laser
        /// </summary>
        private int _y;
        /// <summary>
        /// Getter setter de la position y
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        /// <summary>
        /// Booléen qui détermine si le laser est tiré par le vaisseau ou l'alien
        /// </summary>
        private bool _friendly;
        /// <summary>
        /// Getter setter du booléen friendly
        /// </summary>
        public bool Friendly
        {
            get { return _friendly; }
            private set { _friendly = value; }
        }
        public Laser(int x, int y, int speedY, bool friendly)
        {
            this.X = x;
            this.Y = y;
            this._speedY = speedY;
            this._friendly = friendly;
        }
        public Laser()
        {

        }
        /// <summary>
        /// Méthode qui affiche le laser
        /// </summary>
        public void DrawBullet()
        {
            Console.SetCursorPosition(this.X,this.Y);
            Console.WriteLine(_symbol);
        }
        /// <summary>
        /// Méthode qui efface le laser
        /// </summary>
        public void EraseBullet()
        {
            Console.SetCursorPosition(this._x,this._y);
            Console.WriteLine(_void);
        }
    }
}
