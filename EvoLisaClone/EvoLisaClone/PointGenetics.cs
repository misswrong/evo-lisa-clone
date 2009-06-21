// <copyright file="PointGenetics.cs" company="Jader DIas">
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
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public sealed class PointGenetics
    {
        private static readonly PointGenetics instance = new PointGenetics();
        private Random random = new Random();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static PointGenetics()
        {
        }

        PointGenetics()
        {
        }

        /// <summary>
        /// The public Instance property to use
        /// </summary>
        public static PointGenetics Instance
        {
            get { return instance; }
        }

        public Point Create(int width, int height)
        {
            if (width < 1) throw new ArgumentOutOfRangeException("Argument 'width' must be greater than 0.");
            if (height < 1) throw new ArgumentOutOfRangeException("Argument 'height' must be greater than 0.");
            return new Point(random.Next(width), random.Next(height));
        }
    }
}
