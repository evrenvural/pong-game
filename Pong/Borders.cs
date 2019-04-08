using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Borders : GameObject
    {
        public Collider Collider { get; set; }
        public string Tag { get; set; }
        public Borders(int _x, int _y, int _height, int _width, Rotations _rotation, string _tag) : base(_x, _y, _height, _width, _rotation)
        {
            Collider = new Collider(X, Y, Width, Height);
            Tag = _tag;
        }
    }
}
