using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private Bitmap inputImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Open_Click(object sender, EventArgs e)
        {

            {
                openFileDialog1.Filter = "Изображения (*.bmp, *.png, *.jpg, *jpeg)|*.bmp;*.png;*.jpg;*jpeg|All files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputImage = new Bitmap(openFileDialog1.FileName);
                    if (inputImage.Size.Height > 256 && inputImage.Size.Width > 256)
                    {
                        pictureBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxInput.Image = Image.FromFile(openFileDialog1.FileName);
                    }
                    else
                    {
                        inputImage.Dispose();
                        MessageBox.Show("Wrong inputImage size! Upload another one, please");
                    }

                }
            }
        }

        private void button_Gistogram_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2;
                if (pictureBoxOutput.Image != null)
                {
                    f2 = new Form2(Calculate.CalculateBarChart(pictureBoxOutput.Image));
                    f2.Show();
                }
                else
                {
                    if (inputImage != null)
                    {
                        f2 = new Form2(Calculate.CalculateBarChart(inputImage));
                        f2.Show();
                    }
                    else
                        throw new ArgumentNullException("All images are empty");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                inputImage.Dispose();
                pictureBoxInput.Image = null;
                pictureBoxOutput.Image = null;
            }
            catch (Exception) { MessageBox.Show("All images are already empty"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = Calculate.lowFrequlencyFilter(inputImage);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = Calculate.robertsOperator(inputImage);
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = Calculate.highFrequlencyFilter(inputImage);
        }
    }
}
