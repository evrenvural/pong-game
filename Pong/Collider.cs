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
        private int width;
        private int height;

        public Collider(int _x, int _y, int _width, int _height)
        {
            X = _x;
            Y = _y;
            width = _width;
            height = _height;
        }
        public int[] GetShapeOfColliderX()
        {
            // draws a virtual horizontal line
            int[] temp = new int[width];

            for (int i = 0; i < width; i++)
            {
                temp[i] = X + i;
            }
            return temp;
        }

        public int[] GetShapeOfColliderY()
        {
            // draws a virtual vertical line
            int[] temp = new int[height];

            for (int i = 0; i < height; i++)
            {
                temp[i] = Y + i;
            }
            return temp;
        }
    }
}
