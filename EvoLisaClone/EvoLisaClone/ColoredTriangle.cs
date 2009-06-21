// <copyright file="ColoredTriangle.cs" company="Jader DIas">
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