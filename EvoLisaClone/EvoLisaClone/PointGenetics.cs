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
            if (width < 1)
            {
                throw new ArgumentOutOfRangeException("Argument 'width' must equal to or greater than 1.");
            }
            if (height < 1)
            {
                throw new ArgumentOutOfRangeException("Argument 'height' must equal to or greater than 1.");
            }
            return new Point(random.Next(width), random.Next(height));
        }
    }
}
