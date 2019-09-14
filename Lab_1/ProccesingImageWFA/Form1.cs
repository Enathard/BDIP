using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProccesingImageCL;

namespace ProccesingImageWFA
{
    public partial class Form1 : Form
    {
        Image image;
        Bitmap bitmapImg;

        public Form1()
        {
            InitializeComponent();
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.bmp, *.png, *.jpg)|*.bmp;*.png;*.jpg|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                image = Image.FromFile(openFileDialog.FileName);
                bitmapImg = new Bitmap(openFileDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bitmapImg.Size.Height != 256 || bitmapImg.Width != 256)
            {
                bitmapImg = ProccesingImage.ResizeImg(ref bitmapImg, 256);
            }
            pictureBox1.Image = bitmapImg;
            
            
        }
    }
}
