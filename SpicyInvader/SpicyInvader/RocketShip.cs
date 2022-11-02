using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class RocketShip
    {
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

        private const string _SHIP = @"
                 ▲
                ███
              ███████
            ███████████";

        public string Ship
        {
            get { return _SHIP; }
        }

        public RocketShip(int X, int Y)
        {
            _x = X;
            _y = Y;
        }
    }
}
