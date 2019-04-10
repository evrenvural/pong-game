using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball : GameObject, IPhysics
    {
        private Rotations _moveRotation;
        public int Speed { get; set; }
        public Collider Collider { get; set; }
        public Rotations MoveRotation
        {
            get { return _moveRotation; }
            set
            {
                _moveRotation = (Rotations) (Convert.ToInt16(value) % 8);
            }
        }
        public Dynamic Dynamic { get; set; }

        public Ball(int _x, int _y, int _height, int _width, int _speed, Rotations _rotation) : base(_x, _y, _height, _width, _rotation)
        {
            Speed = _speed;
            Collider = new Collider(X, Y, Width, Height);
            Dynamic = new Dynamic();
        }

        public void Move()
        {
            switch (MoveRotation)
            {
                case Rotations.RIGHT_UP:
                    // Right Up
                    X += Speed;
                    Y -= Speed;
                    break;
                case Rotations.RIGHT:
                    // Right
                    X += Speed;
                    break;
                case Rotations.RIGHT_DOWN:
                    // Right Down
                    X += Speed;
                    Y += Speed;
                    break;
                case Rotations.LEFT_DOWN:
                    // Left Down
                    X -= Speed;
                    Y += Speed;
                    break;
                case Rotations.LEFT:
                    //Left
                    X -= Speed;
                    break;
                case Rotations.LEFT_UP:
                    // Left Up
                    X -= Speed;
                    Y -= Speed;
                    break;
                default:
                    MoveRotation = (Rotations)RandomNumberForRotation.Rndm();
                    break;

            }

            //the new coordinate infos give collider
            Collider.X = X;
            Collider.Y = Y;
        }


    }
}
