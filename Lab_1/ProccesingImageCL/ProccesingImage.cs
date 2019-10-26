using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using java.awt;
using java.awt.image;
using Color = java.awt.Color;

namespace ProccesingImageCL
{
    public class ProccesingImage
    {
        public static Bitmap RandomReplacePixel(Bitmap bitmap, int percent)
        {
            BufferedImage img = new BufferedImage(bitmap);
            int n = img.getHeight() * img.getWidth() * percent / 100;
            int maxWidth = img.getWidth(), maxHeight = img.getHeight();
            Random random = new Random();
            for (int i = 0; i < n / 2; i++)
            {
                img.setRGB((int)((double) random.Next(0, 100) / 100 * maxWidth), (int)((double)random.Next(0, 100) / 100 * maxHeight), new Color(0, 0, 0).getRGB());
                img.setRGB((int)((double)random.Next(0, 100) / 100 * maxWidth), (int)((double)random.Next(0, 100) / 100 * maxHeight), new Color(255, 255, 255).getRGB());
            }
            return img.getBitmap();
        }

        public static Bitmap FragmentCut(Bitmap bitmap, int x1 = 160, int y1 = 160, int x2 = 240, int y2 = 240, int n = 4)
        {
            BufferedImage img = new BufferedImage(bitmap);
            int width = x2 - x1;
            int height = y2 - y1;
            BufferedImage newImg = new BufferedImage(width, height, BufferedImage.TYPE_INT_RGB);
            for (int i = x1, ik = 0; i < x2; i++, ik ++)
            {
                for (int j = y1, jk = 0; j < y2; j++, jk ++)
                {
                    Color color = new Color(img.getRGB(i, j));
                    newImg.setRGB(ik, jk, color.getRGB());
                }
            }
            BufferedImage resizeNewImg = new BufferedImage(width * n, height * n, BufferedImage.TYPE_INT_RGB);
            for (int i = 0, i1 = 0; i < width; i++, i1 += 4)
                for (int j = 0, j1 = 0; j < height; j++, j1 += 4)
                {
                    Color color = new Color(newImg.getRGB(i, j));
                    for (int k = 0; k < n; k++)
                    {
                        resizeNewImg.setRGB(i1 + k, j1 + k, color.getRGB());
                    }
                }
            return resizeNewImg.getBitmap();
        }

        public static Bitmap SetsContrans(Bitmap bitmap)
        {
            BufferedImage img = new BufferedImage(bitmap);
            Color color;
            for (int i = 0; i < img.getWidth(); i++)
            {
                for (int j = 0; j < img.getHeight(); j++)
                {
                    color = new Color(img.getRGB(i, j));
                    int r = color.getRed();
                    int g = color.getGreen();
                    int b = color.getBlue();

                    if (r > 196) r = 196;
                    else if (r < 32) r = 32;
                    if (g > 196) g = 196;
                    else if (g < 32) g = 32;
                    if (b > 196) b = 196;
                    else if (b < 32) b = 32;

                    img.setRGB(i, j, new Color(r, g, b).getRGB());
                }
            }
            return img.getBitmap();
        }

        public static Bitmap DecreaseImageResolution(Bitmap bitmap, int n)
        {
            BufferedImage img = new BufferedImage(bitmap);
            BufferedImage newImg = new BufferedImage(bitmap.Width / n, bitmap.Height / n, BufferedImage.TYPE_INT_RGB);
            for (int i = 0, ik = 0; ik < img.getWidth(null); i++, ik += n)
            {
                for (int j = 0, jk = 0; jk < img.getHeight(null); j++, jk += n)
                {
                    Color color = new Color(img.getRGB(ik, jk));
                    newImg.setRGB(i, j, color.getRGB());
                }
            }
            return newImg.getBitmap();
        }

        public static Bitmap Quantization(Bitmap bitmap, int n)
        {
            BufferedImage img = new BufferedImage(bitmap);
            Color color;
            for (int i = 0; i < img.getWidth(); i++)
            {
                for (int j = 0; j < img.getHeight(); j++)
                {
                    color = new Color(img.getRGB(i, j));
                    if (color.getRed() % n != 0 && color.getRed() != 0)
                        img.setRGB(i, j, new Color(newColor(color.getRed(), n), color.getGreen(), color.getBlue()).getRGB());
                    if (color.getBlue() % n != 0 && color.getBlue() != 0)
                        img.setRGB(i, j, new Color(color.getRed(), color.getGreen(), newColor(color.getBlue(), n)).getRGB());
                    if (color.getGreen() % n != 0 && color.getGreen() != 0)
                        img.setRGB(i, j, new Color(color.getRed(), newColor(color.getGreen(), n), color.getBlue()).getRGB());
                }
            }
            return img.getBitmap();
        }

        private static int newColor(int x, int index)
        {
            while (x % index != 0) --x;
            return x;
        }

        public static Bitmap ResizeImg(ref Bitmap bitmapImg, int sizeX, int sizeY)
        {
            //BufferedImage
            return new Bitmap(bitmapImg, new Size(sizeX, sizeY));
        }

        public static Bitmap ResizeImg(ref Bitmap bitmapImg, int size)
        {
            return ResizeImg(ref bitmapImg, size, size);
        }
    }
}