using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Squad
    {
       

        private List<Alien> _aliens = new List<Alien>();

        public List<Alien> Aliens
        {
            get { return _aliens; }
            private set { _aliens = value; }
        }

        public Squad()
        {
            CreateAlien();
        }

        /// <summary>
        /// Méthode qui créé des aliens et les mets dans une liste
        /// </summary>
        public void CreateAlien()
        {
            int x = 10;
            int y = 7;
            for (int i = 0; i < 8; i++)
            {
                if(i == 4)
                {
                    x = 10;
                    y += 5;
                }
                this._aliens.Add(new Alien(x,y));
                x += 12;
            }
        }

        /// <summary>
        /// Méthode qui permet d'afficher tous les aliens en jeu
        /// </summary>
        public void DrawAllAliens()
        {
            for(int i = 0; i < _aliens.Count; i++)
            {
                this._aliens[i].DrawAlien();
            }
        }

        public void EraseAllAliens()
        {
            for (int i = 0; i < _aliens.Count; i++)
            {
                this._aliens[i].EraseAlien();
            }
        }

        /// <summary>
        /// Méthode qui fait bouger les aliens 
        /// si la position de l'alien est au max elle change sa vitesse pour revenir
        /// </summary>
        public void MoveAllAliens()
        {
            EraseAllAliens();

            int leftAlienX = 1000;
            int rightAlienX = 0;
            foreach (Alien alien in this._aliens)
            {
                if (alien.X < leftAlienX)
                {
                    leftAlienX = alien.X;
                }
                if (alien.X > rightAlienX)
                {
                    rightAlienX = alien.X;
                }
            }

            // Gauche 
            if (this._aliens[0].SpeedX == -1)
            {

                if (leftAlienX <= 2)
                {
                    // inverse la direction des aliens
                    for (int f = 0; f < _aliens.Count; f++)
                    {
                        this._aliens[f].SpeedX = 1;
                        this._aliens[f].Y++;
                    }
                }
                else
                {
                    foreach (Alien alien in this._aliens)
                        alien.X += alien.SpeedX;
                }

            }
            // Droite 
            else
            {
                if (rightAlienX >= 110)
                {
                    // inverse la direction des aliens
                    for (int f = 0; f < _aliens.Count; f++)
                    {
                        this._aliens[f].SpeedX = -1;
                        this._aliens[f].Y++;
                    }
                }
                else
                {                    
                    foreach (Alien alien in this._aliens)
                        alien.X += alien.SpeedX;
                }
                

            }
            
            DrawAllAliens();
        }

        /// <summary>
        /// Méthode qui permet de vérifier si la position Y des aliens
        /// est supérieure ou égale à 40. (perdu ou pas en gros)
        /// </summary>
        /// <returns>True si les aliens sont arrivé à 40 sur la position Y,
        ///          false si les aliens n'y sont pas encore</returns>
        public bool isGameOver()
        {
            foreach(Alien alien in this._aliens)
            {
                if(alien.Y >= 36)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
