// <copyright file="ColoredTriangleGenetics.cs" company="Jader DIas">
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