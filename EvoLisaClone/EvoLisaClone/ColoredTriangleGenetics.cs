using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public sealed class ColoredTriangleGenetics
    {
        private const int NumberOfVertices = 3;
        private static readonly ColoredTriangleGenetics instance = new ColoredTriangleGenetics();
        private Random random = new Random();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static ColoredTriangleGenetics()
        {
        }

        ColoredTriangleGenetics()
        {
        }

        /// <summary>
        /// The public Instance property to use
        /// </summary>
        public static ColoredTriangleGenetics Instance
        {
            get { return instance; }
        }

        public ColoredTriangle Create(int width, int height)
        {
            var points = new List<Point>();
            while (PointExtensions.AreCollinear(points))
            {
                points.Clear();
                for (var i = 0; i < NumberOfVertices; i++)
                {
                    points.Add(PointGenetics.Instance.Create(width + 1, height + 1));
                }
            }
            return new ColoredTriangle()
                {
                    Brush = BrushGenetics.Instance.Create(),
                    Vertices = points
                };
        }
    }
}