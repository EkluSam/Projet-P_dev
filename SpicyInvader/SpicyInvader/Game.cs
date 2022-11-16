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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(25,7);
            Console.Write("TON PSEUDO ? : ");
            char heart = '♥';
            string playerName = Console.ReadLine();
            short playerLife = 3;
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(playerName);                               
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            int xPos = 57; 
            int yPos = 40;

            Ship.DrawRocketShip(xPos, yPos);
            while (true)
            {
                Console.WriteLine("SCORE : ");

                for (int i = 0; i < playerLife;i++)
                {
                    Console.SetCursorPosition(110, 3);
                    Console.Write("Vies : ");
                }
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
