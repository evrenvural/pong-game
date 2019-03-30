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
            Character player = new Character();
            Character enemy = new Character();
            Ball ball = new Ball();

            while (game)
            {
                gameBoard.ClearScreen();
                //Write your codes this area {

                gameBoard.DrawCharacter(player.CoordinateY, true);
                gameBoard.DrawCharacter(enemy.CoordinateY, false);
                gameBoard.DrawBall(ball.CoordinateY, ball.CoordinateX);

                // }
                gameBoard.DrawScreen();
                
            }
        }
    }
}
