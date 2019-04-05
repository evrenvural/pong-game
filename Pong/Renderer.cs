using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Renderer
    {
        private char[,] screen;
        
        public Renderer(int width, int height)
        {
            screen = new char[height, width];
        }

        public void DrawScreen()
        {
            CursorSettings();
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

        public void Draw(GameObject gameObject)
        {
            for (int i = 0; i < gameObject.Height; i++)
            {
                for (int j = 0; j < gameObject.Width; j++)
                {
                    screen[gameObject.Y + i, gameObject.X + j] = '█';
                }
            }
        }
        
    }
}
