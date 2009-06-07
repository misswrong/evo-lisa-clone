using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class Polygon:IEquatable<Polygon>
    {
        private PointF[] vertices;

        public PointF[] Vertices
        {
            get { return this.vertices; }
            set
            {
                if (value == null || value.Length < 3)
                {
                    this.vertices = null;
                }
                else
                {
                    var newVertices = new List<PointF>();
                    for (var index = 1; index < value.Length; index++)
                    {
                        if (!PointExtensions.AreEqual(value[index], value[index - 1]))
                        {
                            newVertices.Add(value[index]);
                        }
                    }
                    if (!PointExtensions.AreEqual(value.First(), value.Last()))
                    {
                        newVertices.Add(value.First());
                    }
                    this.vertices = newVertices.ToArray();
                }
            }
        }

        #region IEquatable<Polygon> Members

        bool AreEqualOrShifted(PointF[] arrayA, PointF[] arrayB, int bIndexEqualToFirstA, int direction)
        {
            var index = bIndexEqualToFirstA;
            for (var count = 0; count < arrayA.Length; count++, index += direction)
            {
                if (index >= arrayA.Length)
                {
                    index = 0;
                }
                if (index < 0)
                {
                    index = arrayA.Length - 1;
                }
                if (!PointExtensions.AreEqual(arrayA[count], arrayB[index]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Equals(Polygon other)
        {
            var isNoPolygon = this.Vertices == null;
            if (other == null || other.Vertices == null)
            {
                return isNoPolygon;
            }
            if (isNoPolygon)
            {
                return false;
            }
            if (this.Vertices.Length == other.Vertices.Length)
            {
                var index = 0;
                for (; index < this.Vertices.Length; index++)
                {
                    if (PointExtensions.AreEqual(this.Vertices[0], other.Vertices[index]))
                    {
                        break;
                    }
                }
                if (index == this.Vertices.Length)
                {
                    return false;
                }
                if (AreEqualOrShifted(this.Vertices, other.Vertices, index, 1))
                {
                    return true;
                }
                return AreEqualOrShifted(this.Vertices, other.Vertices, index, -1);
            }
            return false;
        }

        #endregion

        #region Object Members

        public override bool Equals(object obj)
        {
            var other = obj as Polygon;
            if(other == null)
            {
                return false;
            }
            return this.Equals(other);
        }

        public override int GetHashCode()
        {
            if (this.Vertices == null)
            {
                return 0;
            }
            return this.Vertices.Sum(a => PointExtensions.GetHashCode(a));
        }

        #endregion
    }
}