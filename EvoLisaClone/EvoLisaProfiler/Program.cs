using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvoLisaClone;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace EvoLisaProfiler
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapCloner target = new BitmapCloner();
            var fileName = "smile.png";
            using (var bitmap = new Bitmap(fileName))
            {
                long expectedDistance = 1024 * 8;
                var actual = target.Clone(bitmap, expectedDistance, 2);
                var actualDistance = VectorDrawingGenetics.Instance.CalculateDistance(actual, bitmap);
                using (var cloneBitmap = new Bitmap(bitmap.Width, bitmap.Height))
                {
                    using (var graphics = Graphics.FromImage(cloneBitmap))
                    {
                        GraphicsExtensions.RasterizeVectorDrawing(graphics, actual);
                    }
                    cloneBitmap.Save("smile.bmp", ImageFormat.Bmp);
                }
            }
        }
    }
}
