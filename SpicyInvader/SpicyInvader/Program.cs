using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            
            // Affichage du menu principal
            Menu mainMenu = new Menu();
            mainMenu.DisplayMainMenu();


            Console.ReadLine();
        }
    }
}
