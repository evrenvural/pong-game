﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Enemy : Character, IPhysics
    {
        private Rotations _rotation;
        public Rotations Rotation
        {
            get { return _rotation; }
            set
            {
                if (value != Rotations.TOP && value != Rotations.DOWN)
                {
                    _rotation = Rotations.TOP;
                }
                else
                {
                    _rotation = value;
                }
            }
        }
        public int Speed { get; set; }
        public Enemy(int _x, int _y, int _height, int _width, int _speed) : base(_x, _y, _height, _width)
        {
            Speed = _speed;
        }

        public void Move()
        {
            // Move Up
            if (Rotation == Rotations.TOP)
            {
                if (Y > 1)
                {
                    Y -= Speed;
                    // New coordinate infos give collider
                    Collider.Y = Y;
                }
            }

            // Move Down
            else if (Rotation == Rotations.DOWN)
            {
                if (Y < 18)
                {
                    Y += Speed;
                    // New coordinate infos give collider
                    Collider.Y = Y;
                }
            }
        }
    }
}
