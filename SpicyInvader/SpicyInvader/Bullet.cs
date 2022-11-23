using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Bullet
    {

        private static string[] _alien = new string[1]
        {
            "|",
        };

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
    }
}
