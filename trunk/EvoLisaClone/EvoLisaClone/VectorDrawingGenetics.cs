using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public sealed class VectorDrawingGenetics
    {
        private static readonly VectorDrawingGenetics instance = new VectorDrawingGenetics();
        private Random random = new Random();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static VectorDrawingGenetics()
        {
        }

        VectorDrawingGenetics()
        {
        }

        /// <summary>
        /// The public Instance property to use
        /// </summary>
        public static VectorDrawingGenetics Instance
        {
            get { return instance; }
        }

        public long CalculateDistance(VectorDrawing vectorDrawing, Bitmap bitmap)
        {
            if (ReferenceEquals(null, bitmap)) return 0L;
            var distance = 0L;
            using (var image = new Bitmap(bitmap.Width, bitmap.Height))
            {
                using (var graphics = Graphics.FromImage(image))
                {
                    GraphicsExtensions.RasterizeVectorDrawing(graphics, vectorDrawing);
                }
                for (var x = 0; x < bitmap.Width; x++)
                {
                    for (var y = 0; y < bitmap.Height; y++)
                    {
                        var bitmapColor = bitmap.GetPixel(x, y);
                        var inputColor = image.GetPixel(x, y);
                        distance += Math.Abs(bitmapColor.R - inputColor.R);
                        distance += Math.Abs(bitmapColor.G - inputColor.G);
                        distance += Math.Abs(bitmapColor.B - inputColor.B);
                    }
                }
                return distance;
            }
        }

        public VectorDrawing Create(int width, int height, int length)
        {
            var triangles = new List<ColoredTriangle>();
            for (var i = 0; i < length; i++)
            {
                triangles.Add(ColoredTriangleGenetics.Instance.Create(width, height));
            }
            return new VectorDrawing()
                {
                    Vectors = triangles
                };
        }

        public VectorDrawing CrossOver(VectorDrawing drawingA, VectorDrawing drawingB)
        {
            var triangles = new List<ColoredTriangle>();
            for (var i = 0; i < drawingA.Vectors.Count(); i++)
            {
                if (i%2 == 0)
                {
                    triangles.Add(drawingA.Vectors.ElementAt(i));
                }
                else
                {
                    triangles.Add(drawingB.Vectors.ElementAt(i));
                }
            }
            return new VectorDrawing()
            {
                 Vectors = triangles
            };
        }

        public VectorDrawing Mutate(VectorDrawing drawing, int width, int height)
        {
            var count = drawing.Vectors.Count();
            var triangles = drawing.Vectors.ToList();
            if (count > 1 && random.Next(2) == 0)
            {
                triangles.RemoveAt(random.Next(count));
            }
            else
            {
                triangles.Add(ColoredTriangleGenetics.Instance.Create(width, height));
            }
            return new VectorDrawing()
            {
                Vectors = triangles
            };
        }
    }
}