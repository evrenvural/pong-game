using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Character : GameObject
    {
        public int Speed { get; set; }
        public Collider Collider { get; set; }

        public Character(int _x, int _y, int _height, int _width, int _speed) : base(_x, _y, _height, _width)
        {
            Speed = _speed;
            Collider = new Collider(X, Y, Width, Height);
        }
    }
}
