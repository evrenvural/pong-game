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
                //ball.Move();
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
            borderTop = new Borders(0, 0, 1, WIDTH, "top");
            borderRight = new Borders(WIDTH - 1, 0, HEIGHT, 1, "right");
            borderBot = new Borders(0, HEIGHT - 1, 1, WIDTH, "bot");
            borderLeft = new Borders(0, 0, HEIGHT, 1, "left");
            player = new Player(3, HEIGHT / 2-3, 6, 1, 1);
            enemy = new Enemy(WIDTH - 4, HEIGHT / 2-3, 6, 1, 1);
            Random rndm = new Random();
            
            ball = new Ball(WIDTH / 2, HEIGHT / 2, 1, 1, 2);
            //ball.InitializeMove();
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
                ball.Rotation += 3;
            }
            // Collision status of ball with enemy
            if (Collision.Controls(enemy, ball))
            {
                ball.Rotation += 3;
            }
            // Collision status of ball with top border
            if (Collision.Controls(borderTop, ball))
            {
                ball.Rotation += 3;                     
            }
            // Collision status of ball with right border
            if (Collision.Controls(borderRight, ball))
            {
                ball.Rotation += 3;
            }
            // Collision status of ball with bot border
            if (Collision.Controls(borderBot, ball))
            {
                ball.Rotation += 3;
            }
            // Collision status of ball with left border
            if (Collision.Controls(borderLeft, ball))
            {
                ball.Rotation += 3;
            }
            
        }
    }
}
// Kaldığım Yer:
// 1) Move methodunu (interfaceden gelen) private yap.
// 2) Yansıma sınıfı oluştur topun geliş açısına göre yansıt Characters hızlarına göre açıyı değiştir. Hangi sınıfa girer düşün.
// 3) Önce top speedine de bakabilirsin garip hareketler oluyo çarpışmalarda

    //Kendine ait sayfa, memlekete ait sayfa, memlekette kocaelisporu tanıt, iletişim bilgileri olcak form elemanlarını kullan hepsini burda ve post et o sayfada göster php bu form elemanlarını js ile kontrol et ona göre sınırla isim girdiyse sayı olmasın