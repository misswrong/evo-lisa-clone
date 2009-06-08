using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvoLisaClone
{
    public class VectorDrawing : IEquatable<VectorDrawing>
    {
        public ColoredTriangle[] Vectors { get; set; }

        public bool Equals(VectorDrawing other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Vectors, Vectors);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (VectorDrawing)) return false;
            return Equals((VectorDrawing) obj);
        }

        public override int GetHashCode()
        {
            return (Vectors != null ? Vectors.GetHashCode() : 0);
        }
    }
}
