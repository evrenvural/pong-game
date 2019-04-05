using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    enum Rotations {TOP, RIGHT_UP, RIGHT, RIGHT_DOWN, DOWN, LEFT_DOWN, LEFT, LEFT_UP}
    interface IPhysics
    {
        int Speed { get; set; }
        Rotations Rotation { get; set; }
        void Move();
    }
}
