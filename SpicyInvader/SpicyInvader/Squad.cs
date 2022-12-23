// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe Sqaud qui est utilisée
// avoir un groupe d'aliens.
// ---------------------------------------------
using System.Collections.Generic;
using System;
namespace SpicyInvader
{
    public class Squad
    {
       
        /// <summary>
        /// Liste d'aliens 
        /// </summary>
        private List<Alien> _aliens = new List<Alien>();

        /// <summary>
        /// Getter setter de la liste d'aliens
        /// </summary>
        public List<Alien> Aliens
        {
            get { return _aliens; }
            private set { _aliens = value; }
        }

        public Squad()
        {
            CreateAliens();
        }

        /// <summary>
        /// Méthode qui créé des aliens et les mets dans une liste
        /// </summary>
        public void CreateAliens()
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
            foreach(Alien alien in this._aliens)
            {
                if (alien.Alive)
                {
                    alien.DrawAlien();
                }
            }
        }
        /// <summary>
        /// Méthode qui efface tous les aliens en jeu qui sont en vie
        /// </summary>
        public void EraseAllAliens()
        {
            foreach (Alien alien in this._aliens)
            {
                if (alien.Alive)
                {
                    alien.EraseAlien();
                }
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
                if (alien.X < leftAlienX && alien.Alive)
                {
                    leftAlienX = alien.X;
                }
                if (alien.X > rightAlienX && alien.Alive)
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
                    foreach (Alien alien in this._aliens)
                    {
                        alien.SpeedX = 1;
                        alien.Y++;
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
                    foreach (Alien alien in this._aliens)
                    {
                        alien.SpeedX = -1;
                        alien.Y++;
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
        public bool IsGameOver()
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

        /// <summary>
        /// Méthode qui vérifie les cooldowns des aliens les aliens tirent si le cooldown est au bon moment
        /// </summary>
        /// <param name="bullets">le chargeur qui contient les balles</param>
        /// <param name="difficulty">la difficulté de la partie</param>
        public void VerifyShootingCooldown(Magazine bullets,int difficulty)
        {
            int cooldown = 0; 
            int index = 0;
            // le cooldown va varier en fonction de la difficulté de la partie
            if(difficulty == 2)
            {
                cooldown = 15000;
            }
            else
            {
                cooldown = 20000;
            }

            foreach(Alien alien in this._aliens)
            {               
                alien.ShootCooldown++;
                if (alien.ShootCooldown >= cooldown)
                {
                    alien.ShootCooldown = 0;
                    // Si l'alien a un équipier devant lui il doit vérifier si il est en vie pour savoir si il peut tirer
                    // sinon sa veut dire qu'il est devant et qu'il peut tirer 
                    if (index+4 < this._aliens.Count)
                    {
                        if (!this._aliens[index+4].Alive && this._aliens[index].Alive)
                        {
                            bullets.CreateLaser(alien.X + 4, alien.Y + 6, 1,false);
                        }
                    }
                    else
                    {
                        if (this._aliens[index].Alive)
                        {
                            bullets.CreateLaser(alien.X + 4, alien.Y + 6, 1,false);
                        }
                    }
                }
                index++;
            }
        } 
        /// <summary>
        /// Méthode qui permet de savoir si tous les aliens sont en vie ou pas
        /// </summary>
        /// <returns>true si les aliens sont mort, false si un des aliens est encore en vie</returns>
        public void areAliensDead()
        {
            foreach(Alien alien in this._aliens)
            {
                if (alien.Alive)
                {
                    return;
                }
            }
            this._aliens.Clear();
            CreateAliens();
        }
    }
}
