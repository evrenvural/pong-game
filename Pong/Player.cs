using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Character
    {
        public int CoordinateY { get; set; }
        public int Speed { get; set; }

        public Character()
        {
            Speed = 1;
            CoordinateY = 9;
        }

        public void MoveUp()
        {
            CoordinateY += Speed;
        }

        public void MoveDown()
        {
            CoordinateY -= Speed;
        }

        

    }
}
