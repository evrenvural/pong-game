using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Character : GameObject
    {
        private Rotations _moveRotation;
        public Collider Collider { get; set; }
        public Rotations MoveRotation
        {
            get { return _moveRotation; }
            set
            {
                if (value != Rotations.TOP && value != Rotations.DOWN)
                {
                    _moveRotation = Rotations.TOP;
                }
                else
                {
                    _moveRotation = value;
                }
            }
        }



        public bool IsMove { get; set; }

        public Character(int _x, int _y, int _height, int _width, Rotations _rotation) : base(_x, _y, _height, _width, _rotation)
        {
            Collider = new Collider(X, Y, Width, Height);
        }
        
    }
}
