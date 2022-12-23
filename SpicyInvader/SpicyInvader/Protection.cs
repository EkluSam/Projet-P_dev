// ---------------------------------------------
// Auteur : Samuel EKLU (CIN2A-2022)
// Date   : 23.12.2022
// Description : Classe protection qui gère une liste de murs
// ---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    internal class Protection
    {
        /// <summary>
        /// Liste de murs
        /// </summary>
        private List<Wall> _walls = new List<Wall>();
        /// <summary>
        /// Getter setter de la liste de murs
        /// </summary>
        public List<Wall> Walls
        {
            get { return _walls; }
            private set { _walls = value; }
        }

        public Protection()
        {
            CreateWalls();
        }
        /// <summary>
        /// Méthode qui crée les murs
        /// </summary>
        public void CreateWalls()
        {
            int x = 10;
            int y = 40;
            int wallCount = 0;
            int groupOfWallCount = 0;

            for (int i = 0; i <= 15;i++)
            {
                if(wallCount == 15)
                {
                    
                    // je veux seulement 4 groupes de murs
                    if(groupOfWallCount == 3)
                    {
                        break;
                    }
                    x += 14;
                    i = 0;
                    groupOfWallCount++;
                    wallCount = 0;
                }
                this._walls.Add(new Wall(x,y));
                wallCount++;
                x++;
            }
        }
        /// <summary>
        /// Méthode qui affiche les murs
        /// </summary>
        public void DrawAllWalls()
        {
            foreach(Wall wall in this._walls)
            {
                if (wall.Alive)
                {
                    wall.DrawWall();
                }
            }
        }
        /// <summary>
        /// Méthode qui efface les murs
        /// </summary>
        public void EraseAllWall()
        {
            foreach (Wall wall in this._walls)
            {
                if (wall.Alive)
                {
                    wall.EraseWall();
                }
            }
        }

    }
}
