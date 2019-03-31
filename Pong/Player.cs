﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Player
    {
        public int CoordinateY { get; set; }
        public int CoordinateX { get; set; }
        public int Speed { get; set; }
        

        public Player(int _speed)
        {
            Speed = _speed;
            CoordinateY = 9;
            CoordinateX = 3;
        }

        private void MoveUp()
        {
            if (CoordinateY > 1)
            {
                CoordinateY -= Speed;
            }        
        }

        private void MoveDown()
        {
            if (CoordinateY < 18)
            {
                CoordinateY += Speed;
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

