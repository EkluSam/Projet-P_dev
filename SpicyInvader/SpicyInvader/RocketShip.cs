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

        private static string[] _symbol = new string[3]
        {
            "   ▲   ",
            "▲█████▲",
            "███████",
        };
                                                         

        public RocketShip()
        {
            
        }

        public void DrawSymbol(int x, int y)
        {
            this.X = x;
            this.Y = y;         
            for(int i = 0; i < _symbol.Length; i++)
            {
                Console.SetCursorPosition(x,y);
                Console.Write(_symbol[i]);
                y++;
            }       
        }
    }
}
