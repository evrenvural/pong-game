using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Enemy : Character, IPhysics
    {
       
        public int Speed { get; set; }
        public Enemy(int _x, int _y, int _height, int _width, int _speed, Rotations _rotation) : base(_x, _y, _height, _width, _rotation)
        {
            Speed = _speed;
        }

        public void Move()
        {
            IsMove = false;
            // Move Up
            if (MoveRotation == Rotations.TOP)
            {
                if (Y > 1)
                {
                    Y -= Speed;
                    IsMove = true;
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
                    IsMove = true;
                    // New coordinate infos give collider
                    Collider.Y = Y;
                }
            }
        }
            
            // FOR NOW
        public void Controller()
        {
            // gets input here
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // moves up
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    MoveRotation = Rotations.TOP;
                    Move();
                }
                // moves down
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    MoveRotation = Rotations.DOWN;
                    Move();
                }

            }
        }
    }
}
