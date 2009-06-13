using System.Collections.Generic;
using System.Drawing;
using System.Linq;

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
        public static bool AreCollinear(IEnumerable<Point> points)
        {
            if (ReferenceEquals(null, points))
            {
                return true;
            }
            var pointsArray = points.ToArray();
            if (pointsArray.Length < 3)
            {
                return true;
            }
            var xDifference1 = pointsArray[1].X - pointsArray[0].X;
            var yDifference1 = pointsArray[1].Y - pointsArray[0].Y;
            for (var index = 2; index < pointsArray.Length; index++)
            {
                if (!IsColinear(pointsArray[0], pointsArray[index], xDifference1, yDifference1))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Equals(Point pointA, Point pointB)
        {
            return PointExtensions.GetHashCode(pointA) == PointExtensions.GetHashCode(pointB);
        }

        public static int GetHashCode(Point point)
        {
            return ((point.X << 16) | (point.X >> 16)) ^ point.Y;
        }
    }
}