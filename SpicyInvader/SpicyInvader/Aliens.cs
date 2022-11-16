using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Aliens : RocketShip
    {
<<<<<<< HEAD
        private static string[] _symbol = new string[2]
        {
            "o███o",
            "██u██",
        };
=======
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

        private string _symbol;
>>>>>>> parent of 6feaf3c (Updates)

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

    }
}
