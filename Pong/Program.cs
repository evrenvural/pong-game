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
        static Renderer renderer;
        static Borders borderTop, borderRight, borderBot, borderLeft;
        static Player player;
        static Enemy enemy;
        static Ball ball;

        static void Main(string[] args)
        {
            InitialVariables();

            while (game)
            {
                renderer.ClearScreen();
                //Write your codes this area {

                Draws();
                ball.Move();
                //enemy.Controller();
                player.Controller();
                CollisionControls();
                
                // }
                renderer.DrawScreen();   
            }
        }

        static void InitialVariables()
        {
            game = true;
            renderer = new Renderer(WIDTH, HEIGHT);
            borderTop = new Borders(0, 0, 1, WIDTH, Rotations.RIGHT, "top");
            borderRight = new Borders(WIDTH - 1, 0, HEIGHT, 1, Rotations.TOP, "right");
            borderBot = new Borders(0, HEIGHT - 1, 1, WIDTH, Rotations.RIGHT, "bot");
            borderLeft = new Borders(0, 0, HEIGHT, 1, Rotations.TOP, "left");
            player = new Player(3, HEIGHT / 2 - 3, 6, 1, 1, Rotations.TOP);
            enemy = new Enemy(WIDTH - 4, HEIGHT / 2 - 3, 6, 1, 1, Rotations.TOP);
            ball = new Ball(WIDTH / 2, HEIGHT / 2, 1, 1, 1, Rotations.TOP);
        }

        static void Draws()
        {
            renderer.Draw(player);
            renderer.Draw(enemy);
            renderer.Draw(ball);
            renderer.Draw(borderTop);
            renderer.Draw(borderRight);
            renderer.Draw(borderBot);
            renderer.Draw(borderLeft);
        }

        static void CollisionControls()
        {
            // Collision status of ball with player
            if (Collision.Controls(player, ball))
            {
                ball.MoveRotation = ball.Dynamic.Reflection(ball, player);
            }
            // Collision status of ball with enemy
            if (Collision.Controls(enemy, ball))
            {
                ball.MoveRotation = ball.Dynamic.Reflection(ball, enemy);
            }
            // Collision status of ball with top border
            if (Collision.Controls(borderTop, ball))
            {
                ball.MoveRotation = ball.Dynamic.Reflection(ball, borderTop);
            }
            // Collision status of ball with right border
            if (Collision.Controls(borderRight, ball))
            {
                // GOAL
            }
            // Collision status of ball with bot border
            if (Collision.Controls(borderBot, ball))
            {
                ball.MoveRotation = ball.Dynamic.Reflection(ball, borderBot);
                
            }
            // Collision status of ball with left border
            if (Collision.Controls(borderLeft, ball))
            {
                // GOAL
            }   
        }

    }
}


    