using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public static class GraphicsExtensions
    {
        public static void FillColoredTriangle(Graphics graphics, ColoredTriangle coloredTriangle)
        {
            graphics.FillPolygon(coloredTriangle.Brush, coloredTriangle.Vertices.ToArray());
        }

        public static void RasterizeVectorDrawing(Graphics graphics, VectorDrawing vectorDrawing)
        {
            foreach (var coloredTriangle in vectorDrawing.Vectors)
            {
                FillColoredTriangle(graphics, coloredTriangle);
            }
        }
    }
}
