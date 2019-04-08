using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Collision
    {
        public static bool Controls(Player player, Ball ball)
        {
            bool temp = false;
            
            int[] playerX = player.Collider.GetShapeOfColliderX();
            int[] playerY = player.Collider.GetShapeOfColliderY();
            int[] ballX = ball.Collider.GetShapeOfColliderX();
            int[] ballY = ball.Collider.GetShapeOfColliderY();


            for (int i = 0; i < playerY.Length; i++)
            {
                for (int j = 0; j < playerX.Length; j++)
                {
                    for (int k = 0; k < ballY.Length; k++)
                    {
                        for (int l = 0; l < ballX.Length; l++)
                        {
                            if (playerX[j] + 2 > ballX[l] && playerY[i] == ballY[k])
                            {
                                temp = true;
                            }
                        }
                    }
                }
            }

            return temp;
        }

        public static bool Controls(Enemy enemy, Ball ball)
        {
            bool temp = false;

            int[] enemyX = enemy.Collider.GetShapeOfColliderX();
            int[] enemyY = enemy.Collider.GetShapeOfColliderY();
            int[] ballX = ball.Collider.GetShapeOfColliderX();
            int[] ballY = ball.Collider.GetShapeOfColliderY();


            for (int i = 0; i < enemyY.Length; i++)
            {
                for (int j = 0; j < enemyX.Length; j++)
                {
                    for (int k = 0; k < ballY.Length; k++)
                    {
                        for (int l = 0; l < ballX.Length; l++)
                        {
                            if (enemyX[j] - 2 < ballX[l] && enemyY[i] == ballY[k])
                            {
                                temp = true;
                            }
                        }
                    }
                }
            }

            return temp;
        }

        public static bool Controls(Borders border, Ball ball)
        {
            bool temp = false;

            int[] borderX = border.Collider.GetShapeOfColliderX();
            int[] borderY = border.Collider.GetShapeOfColliderY();
            int[] ballX = ball.Collider.GetShapeOfColliderX();
            int[] ballY = ball.Collider.GetShapeOfColliderY();

            for (int i = 0; i < borderY.Length; i++)
            {
                for (int j = 0; j < borderX.Length; j++)
                {
                    for (int k = 0; k < ballY.Length; k++)
                    {
                        for (int l = 0; l < ballX.Length; l++)
                        {
                            switch (border.Tag)
                            {
                                case "top":
                                    if (borderX[j] == ballX[l] && ballY[k] < borderY[i] + 2)
                                    {
                                        temp = true;
                                    }
                                    break;
                                case "right":
                                    if (borderX[j] - 2 < ballX[l] && ballY[k] == borderY[i])
                                    {
                                        temp = true;
                                    }
                                    break;
                                case "bot":
                                    if (borderX[j] == ballX[l] && ballY[k] > borderY[i] - 2)
                                    {
                                        temp = true;
                                    }
                                    break;
                                case "left":
                                    if (borderX[j] +2 > ballX[l] && ballY[k] == borderY[i])
                                    {
                                        temp = true;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }       
            

            return temp;
        }
    }
}
