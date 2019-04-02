using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Collider
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Collider(int _x, int _y, int _width, int _height)
        {
            X = _x;
            Y = _y;
            Width = _width;
            Height = _height;
        }

        public void SetColliderXY(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public int[] GetShapeOfColliderX()
        {
            // draws a virtual horizontal line
            int[] temp = new int[Width];

            for (int i = 0; i < Width; i++)
            {
                temp[i] = X + i;
            }
            return temp;
        }

        public int[] GetShapeOfColliderY()
        {
            // draws a virtual vertical line
            int[] temp = new int[Height];

            for (int i = 0; i < Height; i++)
            {
                temp[i] = Y + i;
            }
            return temp;
        }
    }
}
