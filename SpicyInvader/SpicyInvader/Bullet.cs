﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Bullet
    {

        private char _bullet = '|';

        private char _void = ' ';

        private int _speedY;
        
        public int SpeedY
        {
            get { return _speedY; }
            private set { _speedY = value; }
        }

        /// <summary>
        /// Position x du laser
        /// </summary>
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Position y du laser
        /// </summary>
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Bullet(int x, int y, int speedY)
        {
            this.X = x;
            this.Y = y;
            this._speedY = speedY;
        }
        public Bullet()
        {

        }

        public void DrawBullet()
        {
            Console.SetCursorPosition(this.X,this.Y);
            Console.WriteLine(_bullet);
        }

        public void EraseBullet()
        {
            Console.SetCursorPosition(this._x,this._y);
            Console.WriteLine(_void);
        }


    }
}
