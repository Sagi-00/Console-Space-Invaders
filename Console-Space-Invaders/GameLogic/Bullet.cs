using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Bullet
    {
        public int BulletPosX { get; set; }
        public int BulletPosY { get; set; }

        public int BulletSpeed { get; private set; } = 1;




        public Bullet(int bulletPosX, int bulletPosY)
        {
            BulletPosX = bulletPosX;
            BulletPosY = bulletPosY;
            
        }


       public void MoveBullet(int Direction)
       {
            BulletPosY += Direction;
       }


    }
}
