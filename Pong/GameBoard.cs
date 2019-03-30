using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class GameBoard
    {
        private char[,] screen;
        
        public GameBoard(int width, int height)
        {
            screen = new char[height, width];
        }

        public void DrawScreen()
        {
            CursorSettings();
            DrawBorders();
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write(screen[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void ClearScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = ' ';
                }
            }
        }

        private void CursorSettings()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
        }

        private void DrawBorders()
        {
            //Left and right borders
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                //Draw left borders
                screen[i, 0] = '█';
                //Draw right borders
                screen[i,screen.GetLength(1)-1] = '█';
            }

            //Top and bottom borders
            for (int i = 0; i < screen.GetLength(1); i++)
            {
                //Draw top borders
                screen[0,i] = '█';
                //Draw bottom borders
                screen[screen.GetLength(0) - 1, i] = '█';
            }
        }
        
        public void DrawCharacter(int coorY, bool isPlayer)
        {
            //Characters are placed on the screen
            if (isPlayer)
            {
                screen[coorY, 3] = '█';
                screen[coorY + 1, 3] = '█';
                screen[coorY + 2, 3] = '█';
                screen[coorY + 3, 3] = '█';
                screen[coorY + 4, 3] = '█';
                screen[coorY + 5, 3] = '█';
            }
            else
            {
                screen[coorY, screen.GetLength(1) - 4] = '█';
                screen[coorY + 1, screen.GetLength(1) - 4] = '█';
                screen[coorY + 2, screen.GetLength(1) - 4] = '█';
                screen[coorY + 3, screen.GetLength(1) - 4] = '█';
                screen[coorY + 4, screen.GetLength(1) - 4] = '█';
                screen[coorY + 5, screen.GetLength(1) - 4] = '█';
            }
        }

        public void DrawBall(int coorY, int coorX)
        {
            //Ball is placed on the screen
            screen[coorY,coorX] = '█';
        }
    }
}
