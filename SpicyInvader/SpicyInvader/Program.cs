// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Programme principal
// ---------------------------------------------
using System;

namespace SpicyInvader
{
    internal class Program
    {
        /// <summary>
        /// Méthode Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(120, 51);
            Console.BufferHeight = 51;

            // Affichage du menu principal
            Menu mainMenu = new Menu();
            Sound.PlayMusic(false);
            Console.SetCursorPosition(0, 0);
            Console.Write("version 1.0");
            mainMenu.DisplayMainMenu();
            
        }
    }
}
