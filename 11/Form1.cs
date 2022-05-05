using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.FromArgb(31, 58, 96));
            Random rand = new Random();
            SolidBrush zxc = new SolidBrush(Color.FromArgb(31, 58, 96));

            SolidBrush whit = new SolidBrush(Color.White);
            SolidBrush yell = new SolidBrush(Color.Yellow);
            SolidBrush awhit = new SolidBrush(Color.AntiqueWhite);
            SolidBrush gray = new SolidBrush(Color.Gray);
            SolidBrush bGray = new SolidBrush(Color.DarkGray);
            SolidBrush sky = new SolidBrush(Color.SkyBlue);
            SolidBrush bGreeneer = new SolidBrush(Color.FromArgb(48, 80, 67));
            SolidBrush bGreener = new SolidBrush(Color.FromArgb(50, 93, 69));
            SolidBrush bGreen = new SolidBrush(Color.FromArgb(51, 100, 71));
            SolidBrush brown = new SolidBrush(Color.FromArgb(61, 56, 54));
            SolidBrush lightBrown = new SolidBrush(Color.FromArgb(85, 72, 72));
            SolidBrush black = new SolidBrush(Color.Black);


            //Земля
            g.FillRectangle(bGreeneer, 0, 310, 900, 110);
            g.FillRectangle(bGreener, 0, 330, 900, 110);

            //Звезды
            int size = 0;
            int count = 0;
            for (int i = 0; i < 1000; i += 10)
            {
                size = rand.Next(2, 5);
                count = rand.Next(1, 5);
                if (count == 1)
                    g.FillRectangle(yell, rand.Next(i, i + 50), rand.Next(0, 300), size, size);
                if (count == 2)
                    g.FillRectangle(whit, rand.Next(i, i + 50), rand.Next(0, 300), size, size);
                if (count == 3)
                    g.FillRectangle(sky, rand.Next(i, i + 50), rand.Next(0, 300), size, size);
                if (count == 4)
                    g.FillRectangle(whit, rand.Next(i, i + 50), rand.Next(0, 300), size, size);
            }
            //Луна
            g.FillEllipse(awhit, 350, 10, 80, 80);
            g.FillEllipse(gray, 385, 20, 10, 10);
            g.FillEllipse(gray, 400, 30, 12, 12);
            g.FillEllipse(gray, 390, 50, 8, 8);
            g.FillEllipse(gray, 403, 60, 15, 15);
            g.FillRectangle(zxc, 310, 10, 80, 80);

            //Замок
            g.FillRectangle(gray, 600, 275, 60, 60);
            g.FillRectangle(brown, 615, 305, 20, 30);
            g.FillRectangle(lightBrown, 618, 335, 15, 40);


            g.FillRectangle(bGray, 560, 250, 40, 90);
            g.FillRectangle(gray, 555, 240, 50, 20);
            g.FillRectangle(gray, 575, 280, 10, 18);
            g.FillRectangle(black, 575, 280, 10, 15);

            g.FillRectangle(bGray, 650, 250, 40, 90);
            g.FillRectangle(gray, 645, 240, 50, 20);
            g.FillRectangle(gray, 665, 280, 10, 18);
            g.FillRectangle(black, 665, 280, 10, 15);

            // Земля
            g.FillRectangle(bGreen, 0, 350, 900, 130);
            g.FillRectangle(lightBrown, 540, 350, 70, 130);
        }
    }
}
