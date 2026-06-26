using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player
    {
        public double PosX {  get; set; }
        public double PosY { get; set; }


        public Player(double posX, double posY )
        {
            PosX = posX;
            PosY = posY;
        }

        public void Move(int dirction ) 
        {
            PosX += dirction;
        }
    }
}
