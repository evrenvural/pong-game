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

        public Ball()
        {
            CoordinateX = 50;
            CoordinateY = 12;
        }
    }
}
