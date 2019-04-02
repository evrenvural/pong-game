using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Enemy : Character
    {
        public Enemy(int _x, int _y, int _height, int _width, int _speed) : base(_x, _y, _height, _width, _speed)
        {

        }

        private void MoveUp()
        {
            if (Y > 1)
            {
                Y -= Speed;
                // New coordinate infos give collider
                Collider.Y = Y;
            }
        }

        private void MoveDown()
        {
            if (Y < 18)
            {
                Y += Speed;
                // New coordinate infos give collider
                Collider.Y = Y;
            }
        }
    }
}
