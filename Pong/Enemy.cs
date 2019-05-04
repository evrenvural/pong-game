using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Enemy : Character, IPhysics, IAI
    {

        private int guessBallX;

        public int Speed { get; set; }
        public Enemy(int _x, int _y, int _height, int _width, int _speed, Rotations _rotation) : base(_x, _y, _height, _width, _rotation)
        {
            Speed = _speed;
            guessBallX = 50;
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
                if (Y <= 18)
                {
                    Y += Speed;

                    // New coordinate infos give collider
                    Collider.Y = Y;
                }
            }
        }

        public void Think(int coordinateY, int coordinateX)
        {
            Random rndm = new Random();
            
            if (guessBallX <= coordinateX)
            {
                if (coordinateY > Y)
                {
                    MoveRotation = Rotations.DOWN;
                    Move();
                }
                else if (coordinateY < Y)
                {
                    MoveRotation = Rotations.TOP;
                    Move();
                }
            }
            else
            {
                guessBallX = rndm.Next(80, 100);
                Console.WriteLine(guessBallX);
            }
        }
    }
}
