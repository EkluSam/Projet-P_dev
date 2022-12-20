using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Menu
    {
        public bool music = false;
        public int difficulty = 1;
        public Menu()
        {

        }

        #region Menu
        /// <summary>
        /// Titre de l'application SLANT
        /// </summary>
        private const string _TITLE = @"
                 _____ _____        _____ ______   _____ _   ___      __     _____  ______ _____   _____ 
                / ____|  __ \ /\   / ____|  ____| |_   _| \ | \ \    / /\   |  __ \|  ____|  __ \ / ____|
               | (___ | |__) /  \ | |    | |__      | | |  \| |\ \  / /  \  | |  | | |__  | |__) | (___  
                \___ \|  ___/ /\ \| |    |  __|     | | | . ` | \ \/ / /\ \ | |  | |  __| |  _  / \___ \ 
                ____) | |  / ____ \ |____| |____   _| |_| |\  |  \  / ____ \| |__| | |____| | \ \ ____) |
               |_____/|_| /_/    \_\_____|______| |_____|_| \_|   \/_/    \_\_____/|______|_|  \_\_____/ 
                                                                                           
        ";
        /// <summary>
        /// Bouton jouer 
        /// </summary>
        private const string _PLAY = @"
                                                     ______  __  _________ 
                                                 __ / / __ \/ / / / __/ _ \
                                                / // / /_/ / /_/ / _// , _/
                                                \___/\____/\____/___/_/|_|             
        ";
        /// <summary>
        /// Bouton Option
        /// </summary>
        private const string _OPTION = @"
                                              ____  ___  ______________  _  __
                                             / __ \/ _ \/_  __/  _/ __ \/ |/ / 
                                            / /_/ / ___/ / / _/ // /_/ /    / 
                                            \____/_/    /_/ /___/\____/_/|_/ 
        ";
        /// <summary>
        /// Bouton highscore
        /// </summary>
        private const string _HIGHSCORE = @"
                                       __ _____________ _______________  ___  ____
                                      / // /  _/ ___/ // / __/ ___/ __ \/ _ \/ __/
                                     / _  // // (_ / _  /\ \/ /__/ /_/ / , _/ _/  
                                    /_//_/___/\___/_//_/___/\___/\____/_/|_/___/     
        ";
        /// <summary>
        /// A propos
        /// </summary>
        private const string _ABOUT = @"
                                          ___     ___  ___  ____  ___  ____  ____
                                         / _ |   / _ \/ _ \/ __ \/ _ \/ __ \/ __/
                                        / __ |  / ___/ , _/ /_/ / ___/ /_/ /\ \  
                                       /_/ |_| /_/  /_/|_|\____/_/   \____/___/                                          
        ";
        /// <summary>
        /// Bouton quitter
        /// </summary>
        private const string _QUIT = @"                                          ____  __  _________________________ 
                                         / __ \/ / / /  _/_  __/_  __/ __/ _ \
                                        / /_/ / /_/ // /  / /   / / / _// , _/
                                        \___\_\____/___/ /_/   /_/ /___/_/|_|
        ";
        /// <summary>
        /// Bouton difficulté
        /// </summary>
        private const string _DIFFICULTY = @"
                                                 ___ _______          ____   __
                                             ___/ (_) _/ _(_)_____ __/ / /__/_/
                                            / _  / / _/ _/ / __/ // / / __/ -_)
                                            \_,_/_/_//_//_/\__/\_,_/_/\__/\__/
        ";
        /// <summary>
        /// Bouton son
        /// </summary>
        private const string _SOUND = @"
                                                       ____           
                                                      / __/__  ___      
                                                     _\ \/ _ \/ _ \   
                                                    /___/\___/_//_/  
        ";
        /// <summary>
        /// Flèche qui indique sur quel bouton le joueur se situe
        /// </summary>
        private const string _NAVARROW = "  <--- ";

        private const string _PAUSE = @"
                                                ____  ___   __  _______ ______
                                               / __ \/   | / / / / ___// ____/
                                              / /_/ / /| |/ / / /\__ \/ __/   
                                             / ____/ ___ / /_/ /___/ / /___   
                                            /_/   /_/  |_\____//____/_____/ 
        ";

        private const string _GAMEOVER = @"
                                    _________    __  _________   ____ _    ____________ 
                                   / ____/   |  /  |/  / ____/  / __ \ |  / / ____/ __ \
                                  / / __/ /| | / /|_/ / __/    / / / / | / / __/ / /_/ /
                                 / /_/ / ___ |/ /  / / /___   / /_/ /| |/ / /___/ _, _/ 
                                 \____/_/  |_/_/  /_/_____/   \____/ |___/_____/_/ |_|                                 
        ";
        #endregion

        public int yPos = 12; // position de base
        public int xPos = 85; // position de base

        /// <summary>
        /// Méthode qui permet la navigation dans le menu
        /// yPos = 12 -> JOUER
        /// yPos = 18 -> OPTION
        /// yPos = 24 -> HIGHSCORE
        /// yPos = 30 -> A PROPOS
        /// yPos = 36 -> QUITTER
        /// </summary>
        public short ArrowMoves()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_NAVARROW);
            short i;

            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                if(Key.Key == ConsoleKey.UpArrow)
                {
                    if(yPos <= 12)
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos = 36;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                    else
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos -= 6;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                }

                if(Key.Key == ConsoleKey.DownArrow)
                {
                    if(yPos >= 36)
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos = 12;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                    else
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos += 6;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                }

                switch (yPos)
                {
                    case 12:
                        if (Key.Key == ConsoleKey.Enter)
                        {
                            i = 1;
                            return i;
                        }                          
                        break;
                    case 18:
                        if (Key.Key == ConsoleKey.Enter)
                        {
                            i = 2;
                            return i;
                        }
                        break;
                    case 24:
                        if (Key.Key == ConsoleKey.Enter)
                        {
                            i = 3;
                            return i;
                        }
                        break;
                    case 30:
                        if (Key.Key == ConsoleKey.Enter)
                        {
                            i = 4;
                            return i;
                        }
                        break;
                    case 36:
                        if (Key.Key == ConsoleKey.Enter)
                        {
                            i = 5;
                            return i;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Méthode qui affiche le titre de l'application
        /// </summary>
        public void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_TITLE);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Méthode qui affiche le menu principal
        /// </summary>
        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.SetWindowSize(120, 50);
            Console.BufferHeight = 50;
            
            Title();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(_PLAY);
            Console.WriteLine(_OPTION);
            Console.WriteLine(_HIGHSCORE);
            Console.WriteLine(_ABOUT);
            Console.WriteLine(_QUIT);

            switch (ArrowMoves())
            {
                case 1:
                    Game jeu = new Game();
                    jeu.Difficulty = difficulty;                  
                    jeu.Play();                   
                    break;
                case 2:
                    Console.Clear();
                    DisplayOptionMenu();
                    break;
                case 3:
                    Console.Clear();
                    // DisplayHighScore();
                    break;
                case 4:
                    Console.Clear();
                    DisplayAbout();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }

        }

        public void DisplayAbout()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_TITLE);
            Console.SetCursorPosition(40, 17);
            string about = "!Space invader réalisé en C# dans projet dev!\n\t\t\t\t\t     Réalisé par Samuel EKLU (CIN2A-2022)\n\t\t\t\t\t        Chef de projet, Xavier Carrel";
            foreach (char c in about)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 24);
            string escape = "  " +
                "" +
                " Appuyez 'Escape' pour revenir en arrière";
            foreach (char c in escape)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
           
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                if (Key.Key == ConsoleKey.Escape)
                {
                    DisplayMainMenu();
                }
            }

            
        }

        /// <summary>
        /// Méthode qui affiche le menu game over
        /// </summary>
        /// <param name="playerScore">score du joueur au moment ou il a perdu</param>
        public void DisplayGameOverMenu(int playerScore)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_GAMEOVER);
            Console.WriteLine("Votre Score : " + playerScore);
        }

        /// <summary>
        /// Méthode qui affiche le menu option
        /// </summary>
        public void DisplayOptionMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_OPTION);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(_DIFFICULTY);
            Console.Write(_SOUND);
            Console.SetCursorPosition(58, 17);
            Console.ForegroundColor = ConsoleColor.Red;
            if(!music)
                Console.Write("OFF");
            else
                Console.Write("ON");
            Console.SetCursorPosition(58, 11);
            Console.ForegroundColor = ConsoleColor.Red;
            if (difficulty == 1)
                Console.WriteLine("FACILE");
            else
                Console.WriteLine("JEDI  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 20);
            Console.Write("Appuyez 'Escape' pour revenir en arrière");
            ArrowMovesOptions();

        }

        /// <summary>
        /// Méthode qui permet de bouger dans le menu option avec les flèches
        /// directionnelles HAUT et BAS
        /// </summary>
        public void ArrowMovesOptions()
        {
            int xPos = 80;
            int yPos = 9;

            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_NAVARROW);

            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    if (yPos <= 9)
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos = 15;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                    else
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos -= 6;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                }

                if (Key.Key == ConsoleKey.DownArrow)
                {
                    if (yPos >= 15)
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos = 9;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                    else
                    {
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write("         ");
                        yPos += 6;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(_NAVARROW);
                    }
                }

                switch (yPos)
                {
                    case 9:
                        if (Key.Key == ConsoleKey.Escape)
                        {
                            DisplayMainMenu();
                        }
                        if (Key.Key == ConsoleKey.Enter)
                        {
                            if (difficulty == 2)
                            {
                                Console.SetCursorPosition(58, 11);
                                Console.Write("FACILE ");
                                difficulty = 1;
                            }
                            else
                            {
                                Console.SetCursorPosition(58, 11);
                                Console.Write("JEDI   ");
                                difficulty = 2;
                            }
                        }
                        break;
                    case 15:
                        if(Key.Key == ConsoleKey.Escape)
                        {
                            DisplayMainMenu();
                        }
                        if (Key.Key == ConsoleKey.Enter)
                        {                           
                            if (!music)
                            {
                                Console.SetCursorPosition(58, 17);
                                Console.Write("ON ");
                                music = true;
                            }
                            else
                            {
                                Console.SetCursorPosition(58, 17);
                                Console.Write("OFF");
                                music = false;
                            }
                        }
                        break;
                }
            }
        }
    }
}
