// <copyright file="VectorDrawing.cs" company="Jader DIas">
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
using System.Linq;

namespace EvoLisaClone
{
    public class VectorDrawing : IEquatable<VectorDrawing>
    {
        public IEnumerable<ColoredTriangle> Vectors { get; set; }

        public bool Equals(VectorDrawing other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.GetHashCode() == other.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as VectorDrawing);
        }

        public override int GetHashCode()
        {
            if (ReferenceEquals(null, this.Vectors) || Vectors.Count() == 0) return 0;
            var hashCode = 0;
            foreach (var triangle in this.Vectors)
            {
                hashCode += triangle.GetHashCode();
            }
            return hashCode;
        }
    }
}
