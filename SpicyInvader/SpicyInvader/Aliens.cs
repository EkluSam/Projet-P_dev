using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Aliens
    {

        private static string[] _symbol = new string[2]
        {
            "o███o",
            "██u██",
        };

        private static string[] _void = new string[2]
        {
            "     ",
            "     ",
        };
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
