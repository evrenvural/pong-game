using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Dynamic
    {
        public Rotations Reflection(Rotations moveRotation, Rotations rotation)
        {

            switch (moveRotation)
            {
                case Rotations.RIGHT_UP:
                    // if the character is horizontal
                    if (rotation == Rotations.RIGHT || rotation == Rotations.LEFT)
                    {
                        moveRotation = Rotations.RIGHT_DOWN;
                    }
                    // if the character is vertical
                    else
                    {
                        moveRotation = Rotations.LEFT_UP;
                    }
                    break;

                case Rotations.RIGHT:
                    // Right
                    moveRotation = Rotations.LEFT;
                    break;

                case Rotations.RIGHT_DOWN:
                    // if the character is horizontal
                    if (rotation == Rotations.RIGHT || rotation == Rotations.LEFT)
                    {
                        moveRotation = Rotations.RIGHT_UP;
                    }
                    // if the character is vertical
                    else
                    {
                        moveRotation = Rotations.LEFT_DOWN;
                    }
                    break;

                case Rotations.LEFT_DOWN:
                    // if the character is horizontal
                    if (rotation == Rotations.RIGHT || rotation == Rotations.LEFT)
                    {
                        moveRotation = Rotations.LEFT_UP;
                    }
                    // if the character is vertical
                    else
                    {
                        moveRotation = Rotations.RIGHT_DOWN;
                    }
                    break;

                case Rotations.LEFT:
                    //Left
                    moveRotation = Rotations.RIGHT;
                    break;

                case Rotations.LEFT_UP:
                    // if the character is horizontal
                    if (rotation == Rotations.RIGHT || rotation == Rotations.LEFT)
                    {
                        moveRotation = Rotations.LEFT_DOWN;
                    }
                    // if the character is vertical
                    else
                    {
                        moveRotation = Rotations.RIGHT_UP;
                    }
                    break;

            }

            return moveRotation;
        }
    }
}
