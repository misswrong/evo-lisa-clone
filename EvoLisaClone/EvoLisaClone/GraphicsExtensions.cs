// <copyright file="GraphicsExtensions.cs" company="Jader DIas">
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

using System.Drawing;
using System.Linq;

namespace EvoLisaClone
{
    public static class GraphicsExtensions
    {
        public static void FillColoredTriangle(Graphics graphics, ColoredTriangle coloredTriangle)
        {
            graphics.FillPolygon(coloredTriangle.Brush, coloredTriangle.Vertices.ToArray());
        }

        public static void RasterizeVectorDrawing(Graphics graphics, VectorDrawing vectorDrawing)
        {
            foreach (var coloredTriangle in vectorDrawing.Vectors)
            {
                FillColoredTriangle(graphics, coloredTriangle);
            }
        }
    }
}
