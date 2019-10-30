using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProccesingImageCL
{
    public class ProccesingImage
    {
        public static Bitmap ResizeImg(ref Bitmap bitmapImg, int sizeX, int sizeY)
        {
            return new Bitmap(bitmapImg, new Size(sizeX, sizeY));
        }

        public static Bitmap ResizeImg(ref Bitmap bitmapImg, int size)
        {
            return ResizeImg(ref bitmapImg, size, size);
        }
    }
}