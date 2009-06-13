using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class VectorDrawingFitness
    {
        public Bitmap Original { get; set; }

        public long CalculateDistance(VectorDrawing vectorDrawing)
        {
            if (ReferenceEquals(null, Original)) return 0L;
            var distance = 0L;
            using (var image = new Bitmap(Original.Width, Original.Height))
            {
                using (var graphics = Graphics.FromImage(image))
                {
                    GraphicsExtensions.RasterizeVectorDrawing(graphics, vectorDrawing);
                }
                for (var x = 0; x < Original.Width; x++)
                {
                    for (var y = 0; y < Original.Height; y++)
                    {
                        var originalColor = Original.GetPixel(x, y);
                        var inputColor = image.GetPixel(x, y);
                        distance += Math.Abs(originalColor.R - inputColor.R);
                        distance += Math.Abs(originalColor.G - inputColor.G);
                        distance += Math.Abs(originalColor.B - inputColor.B);
                    }
                }
                return distance;
            }
        }
    }
}