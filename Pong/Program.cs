using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Program
    {
        static bool game;
        const int HEIGHT = 26;
        const int WIDTH = 100;
        static GameBoard gameBoard;
        static Borders borderTop, borderRight, borderBot, borderLeft;
        static Player player;
        static Enemy enemy;
        static Ball ball;

        static void Main(string[] args)
        {
            InitialVariables();

            while (game)
            {
                gameBoard.ClearScreen();
                //Write your codes this area {
                Draws();
                // }
                gameBoard.DrawScreen();
                
            }
        }

        static void InitialVariables()
        {
            game = true;
            gameBoard = new GameBoard(WIDTH, HEIGHT);
            borderTop = new Borders(0, 0, 1, WIDTH);
            borderRight = new Borders(WIDTH - 1, 0, HEIGHT, 1);
            borderBot = new Borders(0, HEIGHT - 1, 1, WIDTH);
            borderLeft = new Borders(0, 0, HEIGHT, 1);
            player = new Player(3, HEIGHT / 2-3, 6, 1, 1);
            enemy = new Enemy(WIDTH - 4, HEIGHT / 2-3, 6, 1, 1);
            ball = new Ball(WIDTH / 2, HEIGHT / 2, 1, 1, 1);
        }

        static void Draws()
        {
            gameBoard.Draw(player);
            gameBoard.Draw(enemy);
            gameBoard.Draw(ball);
            gameBoard.Draw(borderTop);
            gameBoard.Draw(borderRight);
            gameBoard.Draw(borderBot);
            gameBoard.Draw(borderLeft);
        }
    }
}
