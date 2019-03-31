using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Enemy
    {
        public int CoordinateY { get; set; }
        public int CoordinateX { get; set; }
        public int Speed { get; set; }


        public Enemy(int _speed)
        {
            Speed = _speed;
            CoordinateY = 9;
            CoordinateX = 96;
        }

        private void MoveUp()
        {
            if (CoordinateY > 1)
            {
                CoordinateY -= Speed;
            }
        }

        private void MoveDown()
        {
            if (CoordinateY < 18)
            {
                CoordinateY += Speed;
            }
        }
    }
}
