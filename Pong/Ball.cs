using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball : GameObject
    {
        public int Speed { get; set; }
        public Collider Collider { get; set; }

        public Ball(int _x, int _y, int _height, int _width, int _speed) : base(_x, _y, _height, _width)
        {
            Speed = _speed;
            Collider = new Collider(X, Y, Width, Height);
        }
        
        public void Move(int rotation)
        {
            switch (rotation)
            {
                case 0:
                    // Right Up
                    X += Speed;
                    Y -= Speed;
                    break;
                case 1:
                    // Right
                    X += Speed;
                    break;
                case 2:
                    // Right Down
                    X += Speed;
                    Y += Speed;
                    break;
                case 3:
                    // Left Down
                    X -= Speed;
                    Y += Speed;
                    break;
                case 4:
                    //Left
                    X -= Speed;
                    break;
                case 5:
                    // Left Up
                    X -= Speed;
                    Y -= Speed;
                    break;
            }

            //the new coordinate infos give collider
            Collider.X = X;
            Collider.Y = Y;
        }
    }
}
