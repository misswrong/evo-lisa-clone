using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public sealed class BrushGenetics
    {
        private static readonly BrushGenetics instance = new BrushGenetics();
        private Random random = new Random();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static BrushGenetics()
        {
        }

        BrushGenetics()
        {
        }

        /// <summary>
        /// The public Instance property to use
        /// </summary>
        public static BrushGenetics Instance
        {
            get { return instance; }
        }

        public Brush Create()
        {
            var bytes = new byte[4];
            random.NextBytes(bytes);
            return new SolidBrush(Color.FromArgb(BitConverter.ToInt32(bytes, 0)));
        }
    }
}