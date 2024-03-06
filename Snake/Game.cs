using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    internal class Game
    {
        public Keys Direction { get; set; }
        public Keys Arrow { get; set; }
        private Timer Frame { get; set; }
        private Label lblPontos { get; set; }
        private Panel pnTela { get; set; }

        private int pontos = 0;

        private Food Food;

        private Snake Snake;

        private Bitmap offScreenBitmap;

        private Graphics BitmapGraph;

        private Graphics ScreenGraph;

        public Game(ref Timer timer, ref Label label, ref Panel panel)
        {
            pnTela = panel;
            Frame = timer;
            lblPontos = label;
            offScreenBitmap = new Bitmap(428, 428);
            Snake = new Snake();
            Food = new Food();
            Direction = Keys.Left;
            Arrow = Direction;
        }

        public void StartGame()
        {
            Snake.Reset();
            Food.CreateFood();
            Direction = Keys.Left;
            BitmapGraph = Graphics.FromImage(offScreenBitmap);
            ScreenGraph = pnTela.CreateGraphics();
            Frame.Enabled = true;
        }

        public void Tick()
        {
            if (((Arrow == Keys.Left) && (Direction != Keys.Right)) || 
                ((Arrow == Keys.Right) && (Direction != Keys.Left)) ||
                ((Arrow == Keys.Up) && (Direction != Keys.Down)) ||
                ((Arrow == Keys.Down) && (Direction != Keys.Up))) 
            {
                Direction = Arrow;
            }
            switch (Direction)
            {
                case Keys.Left:
                    Snake.Left();
                    break;
                case Keys.Right:
                    Snake.Right();
                    break;
                case Keys.Up:
                    Snake.Up();
                    break;
                case Keys.Down:
                    Snake.Down(); 
                    break;
            }
            BitmapGraph.Clear(Color.LimeGreen);
            BitmapGraph.DrawImage(Properties.Resources.Maca, (Food.Location.X * 15), (Food.Location.Y * 15), 15, 15);
            bool gameOver = false;
            for (int i = 0; i < Snake.Lenght; i++)
            {
                if (i == 0)
                {
                    BitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#000000")), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15);
                }
                else {
                    BitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#FF4500")), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15);
                }
                if ((Snake.Location[i] == Snake.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }
            ScreenGraph.DrawImage(offScreenBitmap, 0, 0);
            CheckFood();
            if (gameOver)
            {
                GameOver();
            }
        }

        public void CheckFood()
        {
            if (Snake.Location[0] == Food.Location)
            {
                Snake.Eat();
                Food.CreateFood();
                pontos += 100;
                lblPontos.Text = "Pontos: " + pontos; 
            }
        }

        public void GameOver()
        {
            Frame.Enabled = false;
            BitmapGraph.Dispose();
            ScreenGraph.Dispose();
            lblPontos.Text = "Pontos: 0";
            pontos = 0;
            MessageBox.Show("Game Over!");
        }
    }
}
