// <copyright file="VectorDrawingGenetics.cs" company="Jader DIas">
// Copyright (c) Jader Dias. All rights reserved.
// </copyright>
// <author>Jader Dias</author>
// <email>jaderd@gmail.com</email>
// <date>2009-06-21</date>

// This file is part of EvoLisaClone.
//
// EvoLisaClone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// EvoLisaClone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with EvoLisaClone.  If not, see <http://www.gnu.org/licenses/>.

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

        public VectorDrawing Recombine(VectorDrawing drawingA, VectorDrawing drawingB)
        {
            var triangles = new List<ColoredTriangle>();
            var maxLength = Math.Max(drawingA.Vectors.Count(), drawingB.Vectors.Count());
            var minLength = Math.Min(drawingA.Vectors.Count(), drawingB.Vectors.Count());
            var aIsBigger = drawingA.Vectors.Count() == maxLength;
            for (var i = 0; i < maxLength; i++)
            {
                if ((i%2 == 0 && i < minLength) || (i >= minLength && aIsBigger))
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