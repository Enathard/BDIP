using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private string way = @"../../2.jpeg";

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(way);
            pictureBox2.Image = Image.FromFile(way);
            
        }

        public  int size = 300;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            Random rand = new Random();
            double percent = Convert.ToDouble(textBox1.Text);
            double resultOfSize = (percent / 100) * (bitmap.Width * bitmap.Height / 2);
            int step = 0;
            while (step < resultOfSize)
            {
                bitmap.SetPixel(rand.Next(bitmap.Width), rand.Next(bitmap.Height), Color.White);
                bitmap.SetPixel(rand.Next(bitmap.Width), rand.Next(bitmap.Height), Color.Black);
                step++;
            }
            pictureBox2.Image.Save(@"../../20.jpeg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../20.jpeg");
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            int left = 85;
            int right = 170;


            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorR = bitmap.GetPixel(i, j).R;
                    if (bitmap.GetPixel(i, j).R > right)
                        ColorR = right;
                    if (bitmap.GetPixel(i, j).R < left)
                        ColorR = left;
                    ColorG = bitmap.GetPixel(i, j).G;
                    if (bitmap.GetPixel(i, j).G > right)
                        ColorG = right;
                    if (bitmap.GetPixel(i, j).G < left)
                        ColorG = left;
                    ColorB = bitmap.GetPixel(i, j).B;
                    if (bitmap.GetPixel(i, j).B > right)
                        ColorB = right;
                    if (bitmap.GetPixel(i, j).B < left)
                        ColorB = left;
                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../20.jpeg");
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            int hight = 63;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorB = bitmap.GetPixel(i, j).B;
                    if (ColorB > hight)
                        ColorB = hight;
                    ColorR = bitmap.GetPixel(i, j).R;
                    if (ColorR > hight)
                        ColorR = hight;
                    ColorG = bitmap.GetPixel(i, j).G;
                    if (ColorG > hight)
                        ColorG = hight;
                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            pictureBox2.Image.Save(@"../../21.jpeg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../20.jpeg");
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            int hight = 192;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorR = bitmap.GetPixel(i, j).R;
                    if (ColorR < hight)
                        ColorR = hight;
                    ColorG = bitmap.GetPixel(i, j).G;
                    if (ColorG < hight)
                        ColorG = hight;
                    ColorB = bitmap.GetPixel(i, j).B;
                    if (ColorB < hight)
                        ColorB = hight;

                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            }
            pictureBox2.Image.Save(@"../../22.jpeg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            pictureBox2.Image = new Bitmap(pictureBox2.Image, 260, 260);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            pictureBox2.Image = new Bitmap(pictureBox2.Image, new Size(size/2, size/2));
            pictureBox2.Image.Save(@"../../3.jpeg");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            pictureBox2.Image = new Bitmap(pictureBox2.Image, new Size(size / 4, size / 4));
            pictureBox2.Image.Save(@"../../4.jpeg");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            pictureBox2.Image = new Bitmap(pictureBox2.Image, new Size(size / 8, size / 8));
            pictureBox2.Image.Save(@"../../8.jpeg");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            pictureBox2.Image = new Bitmap(pictureBox2.Image, new Size(size / 16, size / 16));
            pictureBox2.Image.Save(@"../../16.jpeg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = getBMPBrightness(Image.FromFile(@"../../2.jpeg"), 2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = getBMPBrightness(Image.FromFile(@"../../2.jpeg"), 4);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = getBMPBrightness(Image.FromFile(@"../../2.jpeg"), 8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = getBMPBrightness(Image.FromFile(@"../../2.jpeg"), 16);
        }

        private Bitmap getBMPBrightness(Image original, int c)
        {
            Bitmap bitmap = new Bitmap(original, size, size);
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                    bitmap.SetPixel(i, j, Color.FromArgb(bitmap.GetPixel(i, j).A, bitmap.GetPixel(i, j).R / c, bitmap.GetPixel(i, j).G / c, bitmap.GetPixel(i, j).B / c));
            return bitmap;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            Rectangle rectangle = new Rectangle(1, 5, 50, 50);
            var pic = (Bitmap)pictureBox1.Image;
            pictureBox2.Image = pic.Clone(rectangle, PixelFormat.DontCare);
            pictureBox2.Image = new Bitmap(pictureBox2.Image, new Size(50 * 4, 50 * 4));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorR = 255 - bitmap.GetPixel(i, j).R;
                    ColorG = 255 - bitmap.GetPixel(i, j).G;
                    ColorB = 255 - bitmap.GetPixel(i, j).B;
                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));

                }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox2.Image;

            if (pictureBox2.Image != null)
            {
                Calculat calc = new Calculat();
                Form2 f2 = new Form2(calc.CalculateBarChart(pictureBox2.Image));
                f2.Show();
            }
            else
                MessageBox.Show("Загрузите изображение");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"../../2.jpeg");
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            int xmin = 78, xmax = 112, ymin = 78, ymax = 112;
            int y, x;
            for (int i = 0; i < bitmap.Width - 1; i++)
            {
                for (int j = 0; j < bitmap.Height - 1; j++)
                {
                    x = (int)(255 * bitmap.GetPixel(i, j).GetBrightness());
                    if (xmax != xmin && x != 0) // исключение деления на ноль
                    {
                        y = ((x - xmin) / (xmax - xmin)) * (ymax - ymin) + ymin;
                        double coef = y / x;
                        int newR = (int)(bitmap.GetPixel(i, j).R * coef);
                        int newB = (int)(bitmap.GetPixel(i, j).B * coef);
                        int newG = (int)(bitmap.GetPixel(i, j).G * coef);

                        bitmap.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                    }

                }
            }


        }
    }
}
