using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            GameBoard gameBoard = new GameBoard(100, 25);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (game)
            {
                gameBoard.DrawScreen();
            }
        }
    }
}
