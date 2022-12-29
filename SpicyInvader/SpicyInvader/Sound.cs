// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe Son
// ---------------------------------------------
using System.Media;
using System;
namespace SpicyInvader
{
    public static class Sound
    {
        /// <summary>
        /// objet SoundPlayer 
        /// </summary>
        private static SoundPlayer gameMusic = new SoundPlayer("Music.wav");

        /// <summary>
        /// Méthode qui joue de la musique ou pas en fonction du booléen music
        /// </summary>
        /// <param name="music">booléen qui détermine si la musique est jouée ou pas</param>
        public static void PlayMusic(bool music)
        {
            if (music)
            {
                gameMusic.PlayLooping();
            }
            else
            {
                gameMusic.Stop();
            }
        }
    }  
}
