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
            for (int i = 0; i < 4; i++)
            {
                this._aliens.Add(new Alien());
            }
        }

        public void DisplayAllAliens()
        {
            int x = 10;
            foreach(Alien alien in this._aliens)
            {
                alien.DrawAlien(x,10);
                x += 6;
            }
        }
    }
}
