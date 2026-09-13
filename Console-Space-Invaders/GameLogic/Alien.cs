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
        public int  AlienDirection { get; set; }
        public int AlienSpeed { get; private set; } = 1;
        public bool IsAlienAlive = true;

        public Alien(int posX , int PosY) 
        {
            AlienPosX = posX;
            AlienPosY = PosY;
        }

        public void MoveAlienHorizontally(int Direction, int ScreenEdge)
        {
            if (AlienPosX + Direction > 0 && AlienPosX + Direction < ScreenEdge)
            {
                AlienPosX += Direction;
            }
            else
            {
                MoveAlienVertically();
                AlienSpeed = AlienSpeed * -1; 
            }
            
                
            
        }
        private void MoveAlienVertically()
        {
            AlienPosY = AlienPosY +1 ;
        }

    }
}
