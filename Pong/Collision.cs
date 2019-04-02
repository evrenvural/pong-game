using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Collision
    {
        public static bool Controls(Character character, Ball ball)
        {
            bool temp = false;

            int[] characterX = character.Collider.GetShapeOfColliderX();
            int[] characterY = character.Collider.GetShapeOfColliderY();
            int[] ballX = ball.Collider.GetShapeOfColliderX();
            int[] ballY = ball.Collider.GetShapeOfColliderY();


            for (int i = 0; i < characterY.Length; i++)
            {
                for (int j = 0; j < characterX.Length; j++)
                {
                    for (int k = 0; k < ballY.Length; k++)
                    {
                        for (int l = 0; l < ballX.Length; l++)
                        {
                            if (characterX[j] + 1 == ballX[l] && characterY[i] == ballY[k])
                            {
                                temp = true;
                            }
                        }
                    }
                }
            }

            return temp;
        }

        public static bool Controls(Borders borders, Ball ball)
        {
            bool temp = false;

            int[] bordersX = borders.Collider.GetShapeOfColliderX();
            int[] bordersY = borders.Collider.GetShapeOfColliderY();
            int[] ballX = ball.Collider.GetShapeOfColliderX();
            int[] ballY = ball.Collider.GetShapeOfColliderY();


            for (int i = 0; i < bordersY.Length; i++)
            {
                for (int j = 0; j < bordersX.Length; j++)
                {
                    for (int k = 0; k < ballY.Length; k++)
                    {
                        for (int l = 0; l < ballX.Length; l++)
                        {
                            if (bordersX[j] + 1 == ballX[l] && bordersY[i] == ballY[k])
                            {
                                temp = true;
                            }
                        }
                    }
                }
            }

            return temp;
        }
    }
}
