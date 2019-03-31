using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int Speed { get; set; }

        public Ball(int _speed)
        {
            CoordinateX = 50;
            CoordinateY = 12;
            Speed = _speed;
        }

        public void Move(int rotation)
        {
            switch (rotation)
            {
                case 0:
                    // Right Up
                    CoordinateX += Speed;
                    CoordinateY -= Speed;
                    break;
                case 1:
                    // Right
                    CoordinateX += Speed;
                    break;
                case 2:
                    // Right Down
                    CoordinateX += Speed;
                    CoordinateY += Speed;
                    break;
                case 3:
                    // Left Down
                    CoordinateX -= Speed;
                    CoordinateY += Speed;
                    break;
                case 4:
                    //Left
                    CoordinateX -= Speed;
                    break;
                case 5:
                    // Left Up
                    CoordinateX -= Speed;
                    CoordinateY -= Speed;
                    break;
            }
        }
    }
}
