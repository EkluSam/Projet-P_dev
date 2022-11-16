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

            Ship.DrawRocketShip(xPos, yPos);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                if (Key.Key == ConsoleKey.RightArrow)
                {
                    if (Ship.X != 112)
                    {
                        Ship.EraseRocketShip(Ship.X, Ship.Y);
                        Ship.X += 1;
                        Ship.DrawRocketShip(Ship.X, Ship.Y);
                    }
                    else
                    {

                    }
                }
                if (Key.Key == ConsoleKey.LeftArrow)
                {
                    if (Ship.X != 4)
                    {
                        Ship.EraseRocketShip(Ship.X, Ship.Y);
                        Ship.X -= 1;
                        Ship.DrawRocketShip(Ship.X, Ship.Y);
                    }
                    else
                    {

                    }
                }
            }
            
            


        }
    }
}
