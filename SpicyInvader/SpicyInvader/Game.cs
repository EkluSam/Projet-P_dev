using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpicyInvader
{
    public class Game
    {
        const int GAME_WIDTH = 120;

        RocketShip Ship = new RocketShip();

        /// <summary>
        /// Méthode PLAY qui lance une partie de Space Invader
        /// </summary>
        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(25,7);
            Console.Write("TON PSEUDO ? : ");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(playerName);                               
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            byte playerLife = 3;
            int playerScore = 0;
            int xPos = 57; 
            int yPos = 40;
            int fps = 0;
            int counter = 0;
            Squad aliens = new Squad();

            Ship.DrawRocketShip(xPos, yPos);

            while (true)
            {

                if (fps == 200)
                {
                    fps = 0;
                    aliens.Move();
                    if(aliens.Aliens[0].Y >= 40)
                    {

                    }
                }




                Console.SetCursorPosition(0, 3);
                Console.WriteLine("SCORE : " + playerScore);

                this.DisplayHearts(playerLife);

                if (Console.KeyAvailable)
                {
                    // Mouvements du vaisseau
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
                fps++;
            }
        }
        /// <summary>
        /// Méthode qui dessine le nombre de vie (en coeurs) du joueurs
        /// </summary>
        /// <param name="playerLife">nombre de vie du joueur</param>
        public void DisplayHearts(byte playerLife)
        {
            char heart = '♥';
            string hearts = "";           
            for (int i = 0; i < playerLife; i++)
            {
                hearts += heart;
            }
            Console.SetCursorPosition(110, 3);
            Console.Write("Vies : " + hearts);
        }

    }
}
