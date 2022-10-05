using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Menu
    {
        public Menu()
        {

        }

        private const string _TITLE = @"
         _____ _____        _____ ______   _____ _   ___      __     _____  ______ _____   _____ 
        / ____|  __ \ /\   / ____|  ____| |_   _| \ | \ \    / /\   |  __ \|  ____|  __ \ / ____|
       | (___ | |__) /  \ | |    | |__      | | |  \| |\ \  / /  \  | |  | | |__  | |__) | (___  
        \___ \|  ___/ /\ \| |    |  __|     | | | . ` | \ \/ / /\ \ | |  | |  __| |  _  / \___ \ 
        ____) | |  / ____ \ |____| |____   _| |_| |\  |  \  / ____ \| |__| | |____| | \ \ ____) |
       |_____/|_| /_/    \_\_____|______| |_____|_| \_|   \/_/    \_\_____/|______|_|  \_\_____/ 
                                                                                           
        ";
        private const string _PLAY = @"
                                     ______  __  _________ 
                                 __ / / __ \/ / / / __/ _ \
                                / // / /_/ / /_/ / _// , _/
                                \___/\____/\____/___/_/|_|             
        ";

        private const string _OPTION = @"
                              ____  ___  ______________  _  __
                             / __ \/ _ \/_  __/  _/ __ \/ |/ / 
                            / /_/ / ___/ / / _/ // /_/ /    / 
                            \____/_/    /_/ /___/\____/_/|_/ 
        ";

        private const string _HIGHSCORE = @"
                           __ _____________ _______________  ___  ____
                          / // /  _/ ___/ // / __/ ___/ __ \/ _ \/ __/
                         / _  // // (_ / _  /\ \/ /__/ /_/ / , _/ _/  
                        /_//_/___/\___/_//_/___/\___/\____/_/|_/___/     
        ";

        private const string _ABOUT = @"
                           ___     ___  ___  ____  ___  ____  ____
                          / _ |   / _ \/ _ \/ __ \/ _ \/ __ \/ __/
                         / __ |  / ___/ , _/ /_/ / ___/ /_/ /\ \  
                        /_/ |_| /_/  /_/|_|\____/_/   \____/___/  
                                         
        ";

        private const string _QUIT = @"
                          ____  __  _________________________ 
                         / __ \/ / / /  _/_  __/_  __/ __/ _ \
                        / /_/ / /_/ // /  / /   / / / _// , _/
                        \___\_\____/___/ /_/   /_/ /___/_/|_|
        ";

        private const string _DIFFICULTY = @"
                             ___ _______          ____   __
                         ___/ (_) _/ _(_)_____ __/ / /__/_/
                        / _  / / _/ _/ / __/ // / / __/ -_)
                        \_,_/_/_//_//_/\__/\_,_/_/\__/\__/
        ";

        private const string _NAVARROW = "  <--- ";

        public int yPos = 12;
        public int xPos = 75;
        public void ArrowMoves()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_NAVARROW);

            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                if(Key == ConsoleKey.UpArrow)
                {

                }
            }
        }
        public void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_TITLE);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void DisplayMainMenu()
        {
            Console.SetWindowSize(120, 50);
            Console.BufferHeight = 50;

            Title();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(_PLAY);
            Console.WriteLine(_OPTION);
            Console.WriteLine(_HIGHSCORE);
            Console.WriteLine(_ABOUT);
            Console.WriteLine(_QUIT);

            ArrowMoves();
        }
        public void DisplayOptionMenu()
        {
            Console.WriteLine(_DIFFICULTY);
        }
    }
}
