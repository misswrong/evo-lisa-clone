using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;

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
                hashCode = this.Brush.GetHashCode();
            }
            if (!ReferenceEquals(null, this.Vertices))
            {
                var hasher = new SHA1Managed();
                foreach(var vertice in this.Vertices)
                {
                    hashCode += BitConverter.ToInt32(hasher.ComputeHash(BitConverter.GetBytes(vertice.GetHashCode())), 0);
                }
            }
            return hashCode;
        }

        #endregion
    }
}