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
            int xPos = 57; 
            int yPos = 40;
            
            Ship.DrawSymbol(xPos, yPos);


        }
    }
}
