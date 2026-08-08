using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Alien
    {
        public int AlienPosX { get; set; }
        public int AlienPosY { get; set; }
        public int AlienSpeed { get; private set; } = 1;
        public bool IsAlienAlive = true;

        public Alien(int posX , int PosY) 
        {
            AlienPosX = posX;
            AlienPosY = PosY;
        }




    }
}
