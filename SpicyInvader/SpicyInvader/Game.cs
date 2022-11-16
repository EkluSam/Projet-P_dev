using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Game
    {
        RocketShip Ship = new RocketShip();

        public void Play()
        {
            Console.Clear();

            
            Ship.DrawSymbol(57, 40);

        }
    }
}
