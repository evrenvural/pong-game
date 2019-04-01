using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Player : Character
    {
        public Player(int _x, int _y, int _height, int _width, int _speed) : base(_x, _y, _height, _width, _speed)
        {

        }

        private void MoveUp()
        {
            if (Y > 1)
            {
                Y -= Speed;
            }        
        }

        private void MoveDown()
        {
            if (Y < 18)
            {
                Y += Speed;
            }
        }

        public void Controller()
        {
            // gets input here
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.W)
                {
                    MoveUp();
                }
                else if (keyInfo.Key == ConsoleKey.S)
                {
                    MoveDown();
                }

            }

        }


    }


}

