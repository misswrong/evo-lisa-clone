using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public static class PointExtensions
    {
        public static bool AreEqual(PointF pointA, PointF pointB)
        {
            return (pointA.X == pointB.X) && (pointA.Y == pointB.Y);
        }

        public static int GetHashCode(PointF point)
        {
            return point.X.GetHashCode() + point.Y.GetHashCode();
        }
    }
}
