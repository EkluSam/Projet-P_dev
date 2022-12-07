using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public class Magazine
    {

        private List<Bullet> _bullets = new List<Bullet>();

        private int CurrentBullets;

        public List<Bullet> Bullets
        {
            get { return _bullets; }
            private set { _bullets = value; }
        }

        public Magazine()
        {
            CurrentBullets = 0;
        }
        public void CreateBullet(int x, int y)
        {
            if (Bullets.Count < 7)
            {
                Bullets.Add(new Bullet(x, y - 1));
                CurrentBullets++;          
            }
            else
            {

            }
        }

        public void DrawAllBullets()
        {
            for(int i = 0; i < Bullets.Count; i++)
            {
                this.Bullets[i].DrawBullet();
            }
        }

        public void EraseAllBullets()
        {
            for (int i = 0; i < Bullets.Count; i++)
            {
                this.Bullets[i].EraseBullet();
            }
        }

        public void MoveAllBullets()
        {
            EraseAllBullets();
            for (int i = 0; i < Bullets.Count;i++)
            {
                Bullets[i].Y -= Bullets[i].SpeedY;
            }
            DrawAllBullets();
        }
    }
}
