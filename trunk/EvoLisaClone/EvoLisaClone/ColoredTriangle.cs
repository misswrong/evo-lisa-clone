using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace EvoLisaClone
{
    public class ColoredTriangle : IEquatable<ColoredTriangle>
    {
        private IEnumerable<Point> vertices;

        public IEnumerable<Point> Vertices
        {
            get
            {
                return this.vertices;
            }
            set
            {
                if (PointExtensions.AreCollinear(value))
                {
                    this.vertices = null;
                }
                else
                {
                    this.vertices = value;
                }
            }
        }

        public Brush Brush { get; set; }

        #region IEquatable<ColoredTriangle> Members

        public bool Equals(ColoredTriangle other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.GetHashCode() == other.GetHashCode();
        }

        #endregion

        #region Object Members

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ColoredTriangle);
        }

        public override int GetHashCode()
        {
            var hashCode = 0;
            if (!ReferenceEquals(null, this.Brush))
            {
                hashCode += this.Brush.GetHashCode();
            }
            if (!ReferenceEquals(null, this.Vertices))
            {
                hashCode += this.Vertices.Sum(a => PointExtensions.GetHashCode(a));
            }
            return hashCode;
        }

        #endregion
    }
}