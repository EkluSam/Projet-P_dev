// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe Magazine qui contient une liste de lasers
// ---------------------------------------------
using System.Collections.Generic;

namespace SpicyInvader
{
    public class Magazine
    {
        /// <summary>
        /// Liste de lasers 
        /// </summary>
        private List<Laser> _lasers = new List<Laser>();
        /// <summary>
        /// Getter setter de la liste de lasers
        /// </summary>
        public List<Laser> Lasers
        {
            get { return _lasers; }
            private set { _lasers = value; }
        }
        /// <summary>
        /// Compteur des lasers des aliens
        /// </summary>
        private int _currentAlienLasers = 0;
        /// <summary>
        /// Getter setter du compteur des lasers d'aliens
        /// </summary>
        public int CurrentAlienLasers
        {
            get { return _currentAlienLasers; }
            set { _currentAlienLasers = value; }
        }
        /// <summary>
        /// Compteur des lasers du vaisseau
        /// </summary>
        private int _currentShipLasers = 0;
        /// <summary>
        /// Getter setter du compteur de lasers du vaisseau
        /// </summary>
        public int CurrentShipLasers
        {
            get { return _currentShipLasers; }
            set { _currentShipLasers = value; }
        }

       
        public Magazine()
        {
            
        }

        /// <summary>
        /// Méthodes qui crée un laser allié ou enemy
        /// </summary>
        /// <param name="x">position x du laser</param>
        /// <param name="y">position y du laser</param>
        /// <param name="speedY">direction du laser</param>
        /// <param name="friendly">booléen allié ou pas</param>
        public void CreateLaser(int x, int y,int speedY,bool friendly)
        {
            if (friendly)
            {
                if (CurrentShipLasers < 5)
                {
                    Lasers.Add(new Laser(x, y - 1, speedY, friendly));
                    _currentShipLasers++;
                }
            }
            else 
            {
                Lasers.Add(new Laser(x, y - 1, speedY, friendly));
                _currentAlienLasers++;              
            }      

        }

        /// <summary>
        /// Méthode qui affiche tous les lasers
        /// </summary>
        public void DrawAllBullets()
        {
            for(int i = 0; i < Lasers.Count; i++)
            {
                this.Lasers[i].DrawBullet();
            }
        }
        /// <summary>
        /// Méthode qui efface tous les lasers
        /// </summary>
        public void EraseAllBullets()
        {
            for (int i = 0; i < Lasers.Count; i++)
            {
                this.Lasers[i].EraseBullet();
            }
        }
        /// <summary>
        /// Méthode qui déplace tous les laser en fonction de leur vitesse
        /// </summary>
        public void MoveAllBullets()
        {
            EraseAllBullets();
            for (int i = 0; i < Lasers.Count;i++)
            {
                Lasers[i].Y += Lasers[i].SpeedY;
            }
            DrawAllBullets();
        }
    }
}
