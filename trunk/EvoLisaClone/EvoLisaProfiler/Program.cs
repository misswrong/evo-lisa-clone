using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvoLisaClone;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Globalization;

namespace EvoLisaProfiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "smile.png";
            using (var bitmap = new Bitmap(fileName))
            {
                var bestTiming = long.MaxValue;
                var lastTiming = bestTiming;
                var population = 0;
                do
                {
                    bestTiming = lastTiming;
                    population++;
                    var stopwatch = Stopwatch.StartNew();
                    long expectedDistance = 1024 * 16;
                    new BitmapCloner().Clone(bitmap, expectedDistance, population);
                    lastTiming = stopwatch.ElapsedTicks;
                } while (lastTiming < bestTiming);
                MessageBox.Show((population - 1).ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}