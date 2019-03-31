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
            Player player = new Player(1);
            Enemy enemy = new Enemy(1);
            Ball ball = new Ball(1);

            while (game)
            {
                gameBoard.ClearScreen();
                //Write your codes this area {
                player.Controller();
                gameBoard.DrawCharacter(player.CoordinateX, player.CoordinateY, true);
                gameBoard.DrawCharacter(enemy.CoordinateX, enemy.CoordinateY, false);
                
                //ball.Move(1);
                gameBoard.DrawBall(ball.CoordinateY, ball.CoordinateX);

                // }
                gameBoard.DrawScreen();
                
            }
        }


    }
}
