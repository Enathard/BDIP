using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Calculat
    {
        public Image CalculateBarChart(Image image)
        {
            Bitmap barChart = null;
            if (image != null)
            {
                int width = 256, height = 256; // width = 400, для увеличения масштаба
                Bitmap bmp = new Bitmap(image);
                barChart = new Bitmap(width, height);
                int[] B = new int[256];
                int i, j;
                Color color;
                for (i = 0; i < bmp.Width; ++i)
                    for (j = 0; j < bmp.Height; ++j)
                    {
                        color = bmp.GetPixel(i, j);

                        ++B[color.B];
                    }
                int max = 0;
                for (i = 0; i < 256; ++i)
                {

                    if (B[i] > max)
                        max = B[i];
                }
                double point = (double)max / height;
                for (i = 0; i < width - 3; ++i)
                {
                    for (j = height - 1; j > height - B[i] / point; --j) // height - B[i / 3] / point
                    {
                        barChart.SetPixel(i, j, Color.Blue);
                    }
                }
            }
            else
                barChart = new Bitmap(1, 1);
            return barChart;
        }
    }
}
