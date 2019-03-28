using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Player
    {
        private int coordinatX;
        private int coordinateY;
        private int speed = 1;

        public Player()
        {
            speed = 1;
            coordinatX = 3;
        }

        public void MoveUp()
        {
            coordinateY += speed;
        }

        public void MoveDown()
        {
            coordinateY -= speed;
        }



    }
}
