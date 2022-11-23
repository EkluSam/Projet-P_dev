using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    class Squad
    {
        private List<Alien> _aliens = new List<Alien>();

        public List<Alien> Aliens
        {
            get { return _aliens = new List<Alien>(); }
            set { _aliens = value; }
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

        public void RemoveAllAliens()
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
        public void Move()
        {
            RemoveAllAliens();

            int leftAlienX = 60;
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
           
            for (int i = 0; i < _aliens.Count; i++)
            {
                this._aliens[i].X += this._aliens[i].SpeedX;
                if (rightAlienX >= this._aliens[i].MaxX - 10)
                {
                    // inverse la direction des aliens
                    for (int f = 0; f < _aliens.Count; f++)
                    {
                        this._aliens[f].Y += this._aliens[f].SpeedY;
                        this._aliens[f].SpeedX = -this._aliens[f].SpeedX;
                    }
                }
            }

            DrawAllAliens();
        }
    }
}
