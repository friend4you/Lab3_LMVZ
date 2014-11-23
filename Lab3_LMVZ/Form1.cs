using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab3_LMVZ
{
    public partial class Form1 : Form
    {
        Graphics graph;
        int dy;
        Point carPoint;
        public Form1()
        {
            InitializeComponent();
            SettingPanel.Left = 276;
            SettingPanel.Top = 116;
            dy = 0;
            carPoint = new Point(500, 600);


            //graphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, 100, 200);
            //Size carSize = new Size(200, 100);
            //Image car1 = new Bitmap("car.jpg");
            //Bitmap car = new Bitmap(car1, carSize);
            //graphics.DrawImage(car, 1 , 1);





        }
        #region // Graphics
        private void StartGameBtn_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Нажмите, что бы начать игру.";
        }

        private void StartGameBtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать!";
        }

        private void SettingBtn_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Нажмите, что бы зайти в настройки игры.";
        }

        private void SettingBtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать!";
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Нажмите, что бы выйти из игры.";
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать!";
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            SettingPanel.Visible = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = true;
        }


        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            graph = panel2.CreateGraphics();
            //Image bgrace = new Bitmap("bgroad11.jpg");
            //Image car = new Bitmap("car.tif");


            //Image car1 = new Bitmap(car, new Size(75, 160));
            //graph.DrawImage(car1, 360, 480);
            //graph.DrawImage(bgrace, 0,0);

            //graph.DrawRectangle(new Pen(Color.Black), 0, 0, 120, 120);

        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(panel2.Width, panel2.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Image bgroad = new Bitmap("bgroad.jpg");
            Image car = new Bitmap("car.tif");
            Image car1 = new Bitmap(car, new Size(75, 160));
            BgMove(bgroad, graph, car1);
            
            
            graph.DrawImage(bmp, 0, 0);

        }
        public void BgMove(Image bg, Graphics gr, Image car)
        {
            Bitmap bmp = new Bitmap(bg.Height, bg.Width);
            Graphics g = Graphics.FromImage(bmp);
            dy = dy + 15;
            
            g.ScaleTransform(0.75F, 0.75F);
            
            if (dy >= panel2.Height+220) dy = 0;
            g.DrawImage(bg, 0, dy);
            g.DrawImage(bg, 0, -bg.Height-220 + dy);
            g.DrawImage(car, carPoint.X, carPoint.Y);
            
            gr.DrawImage(bmp, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            Draw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyValue)
            { 
                case 75:
                    carPoint = new Point(carPoint.X - 300, carPoint.Y);
                    Draw();
                    break;
                case 77:
                    carPoint = new Point(carPoint.X + 300, carPoint.Y);
                    break;
                default:
                    break;
            }
            
        }      


    }
}
