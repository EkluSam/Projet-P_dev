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

        private int _currentAlienBullets = 0;

        public int CurrentAlienBullets
        {
            get { return _currentAlienBullets; }
            set { _currentAlienBullets = value; }
        }

        private int _currentShipBullets = 0;

        public int CurrentShipBullets
        {
            get { return _currentShipBullets; }
            set { _currentShipBullets = value; }
        }

        public List<Bullet> Bullets
        {
            get { return _bullets; }
            private set { _bullets = value; }
        }

        public Magazine()
        {
            
        }
        public void CreateBullet(int x, int y,int speedY,bool friendly)
        {
            if (friendly)
            {
                if (CurrentShipBullets < 5)
                {
                    Bullets.Add(new Bullet(x, y - 1, speedY));
                    _currentShipBullets++;
                }
            }
            else
            {
                    Bullets.Add(new Bullet(x, y - 1, speedY));
                    _currentAlienBullets++;              
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
                Bullets[i].Y += Bullets[i].SpeedY;
            }
            DrawAllBullets();
        }
    }
}
