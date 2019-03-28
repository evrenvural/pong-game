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
            ClearScreen();
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

        private void ClearScreen()
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

    }
}
