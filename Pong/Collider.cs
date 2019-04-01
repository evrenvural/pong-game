using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Collider
    {
        public int width { get; set; }
        public int height { get; set; }

        public Collider(int _width, int _height)
        {
            width = _width;
            height = _height;
        }

        public int[] ShapeOfColliderX(int coorX)
        {
            // draws a virtual horizontal line
            int[] temp = new int[width];

            for (int i = 0; i < width; i++)
            {
                temp[i] = coorX + i;
            }
            return temp;
        }

        public int[] ShapeOfColliderY(int coorY)
        {
            // draws a virtual vertical line
            int[] temp = new int[height];

            for (int i = 0; i < height; i++)
            {
                temp[i] = coorY + i;
            }
            return temp;
        }
    }
}
