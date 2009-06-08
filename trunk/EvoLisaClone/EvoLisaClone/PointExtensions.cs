using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public static class PointExtensions
    {
        private static bool IsColinear(Point first, Point point, int xDifference1, int yDifference1)
        {
            var xDifference2 = point.X - first.X;
            var yDifference2 = point.Y - first.Y;
            return (xDifference1 * yDifference2) == (xDifference2 * yDifference1);
        }

        /// <summary>
        /// Verifies if the points are in a straight line.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <returns>Whether the points are colinear or not.</returns>
        public static bool AreColinear(Point[] points)
        {
            if (points == null || points.Length < 3)
            {
                return true;
            }
            var xDifference1 = points[1].X - points[0].X;
            var yDifference1 = points[1].Y - points[0].Y;
            for (var index = 2; index < points.Length; index++)
            {
                if(!IsColinear(points[0], points[index], xDifference1, yDifference1))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Equals(Point pointA, Point pointB)
        {
            if (ReferenceEquals(null, pointA)) return ReferenceEquals(null, pointB);
            if (ReferenceEquals(pointA, pointB)) return true;
            return PointExtensions.GetHashCode(pointA) == PointExtensions.GetHashCode(pointB);
        }

        public static int GetHashCode(Point point)
        {
            return point.X.GetHashCode() << 16 + point.Y.GetHashCode();
        }
    }
}