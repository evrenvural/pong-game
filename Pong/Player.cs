using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Player : Character, IPhysics
    {
        private Rotations _moveRotation;
        public Player(int _x, int _y, int _height, int _width, int _speed, Rotations _rotation) : base(_x, _y, _height, _width, _rotation)
        {
            Speed = _speed;
        }


        public int Speed { get; set; }

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

        public void Move()
        {
            // Move Up
            if (MoveRotation == Rotations.TOP)
            {
                if (Y > 1)
                {
                    Y -= Speed;
                    // New coordinate infos give collider
                    Collider.Y = Y;
                }
            }

            // Move Down
            else if (MoveRotation == Rotations.DOWN)
            {
                if (Y < 18)
                {
                    Y += Speed;
                    // New coordinate infos give collider
                    Collider.Y = Y;
                }
            }

        }

        public void Controller()
        {
            // gets input here
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // moves up
                if (keyInfo.Key == ConsoleKey.W)
                {
                    MoveRotation = Rotations.TOP;
                    Move();
                }
                // moves down
                else if (keyInfo.Key == ConsoleKey.S)
                {
                    MoveRotation = Rotations.DOWN;
                    Move();
                }

            }
        }
        
    }
}
