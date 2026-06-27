using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player
    {
        public int PlayerPosX {  get; set; }
        public int PlayerPosY { get; set; }

        public int PlayerSpeed { get; private set; } = 3;

        public Player(int posX, int posY )
        {
            PlayerPosX = posX;
            PlayerPosY = posY;
        }

        public void Move(int Direction , int ScreenEdge) 
        {
            if(PlayerPosX + Direction > 0 && PlayerPosX+Direction < ScreenEdge)
            {
                PlayerPosX += Direction;
            } 
        }
    }
}
