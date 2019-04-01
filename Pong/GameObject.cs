using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public GameObject(int _x, int _y, int _height, int _width)
        {
            X = _x;
            Y = _y;
            Height = _height;
            Width = _width;
        }
    }
}
