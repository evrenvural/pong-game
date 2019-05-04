using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Dynamic
    {
        public Rotations Reflection(Ball ball, Borders border)
        {

            switch (ball.MoveRotation)
            {
                case Rotations.RIGHT_UP:
                    // if the character is horizontal
                    if (border.Rotation == Rotations.RIGHT || border.Rotation == Rotations.LEFT)
                    {
                        ball.MoveRotation = Rotations.RIGHT_DOWN;
                    }
                    // if the character is vertical
                    else
                    {
                        ball.MoveRotation = Rotations.LEFT_UP;
                    }
                    break;

                case Rotations.RIGHT:
                    // Right
                    ball.MoveRotation = Rotations.LEFT;
                    break;

                case Rotations.RIGHT_DOWN:
                    // if the character is horizontal
                    if (border.Rotation == Rotations.RIGHT || border.Rotation == Rotations.LEFT)
                    {
                        ball.MoveRotation = Rotations.RIGHT_UP;
                    }
                    // if the character is vertical
                    else
                    {
                        ball.MoveRotation = Rotations.LEFT_DOWN;
                    }
                    break;

                case Rotations.LEFT_DOWN:
                    // if the character is horizontal
                    if (border.Rotation == Rotations.RIGHT || border.Rotation == Rotations.LEFT)
                    {
                        ball.MoveRotation = Rotations.LEFT_UP;
                    }
                    // if the character is vertical
                    else
                    {
                        ball.MoveRotation = Rotations.RIGHT_DOWN;
                    }
                    break;

                case Rotations.LEFT:
                    //Left
                    ball.MoveRotation = Rotations.RIGHT;
                    break;

                case Rotations.LEFT_UP:
                    // if the character is horizontal
                    if (border.Rotation == Rotations.RIGHT || border.Rotation == Rotations.LEFT)
                    {
                        ball.MoveRotation = Rotations.LEFT_DOWN;
                    }
                    // if the character is vertical
                    else
                    {
                        ball.MoveRotation = Rotations.RIGHT_UP;
                    }
                    break;

            }

            return ball.MoveRotation;
        }

        public Rotations Reflection(Ball ball, Character character)
        {

            switch (ball.MoveRotation)
            {
                case Rotations.RIGHT_UP:

                    ball.MoveRotation = Rotations.LEFT_UP;
              
                    break;

                case Rotations.RIGHT:
               
                    ball.MoveRotation = Rotations.LEFT;

                    break;

                case Rotations.RIGHT_DOWN:
                  
                   ball.MoveRotation = Rotations.LEFT_DOWN;
                   break;

                case Rotations.LEFT_DOWN:
                   
                    ball.MoveRotation = Rotations.RIGHT_DOWN;
                    break;

                case Rotations.LEFT:

                    ball.MoveRotation = Rotations.RIGHT;
                    
                    break;

                case Rotations.LEFT_UP:

                    ball.MoveRotation = Rotations.RIGHT_UP;
                    

                    break;

            }

            return ball.MoveRotation;
        }

    }
}
