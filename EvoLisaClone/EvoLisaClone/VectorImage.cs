using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class VectorImage:IEquatable<VectorImage>
    {
        public IEnumerable<DrawnPolygon> Vectors { get; set; }

        public static VectorImage Merge(VectorImage imageA, VectorImage imageB)
        {
            return new VectorImage();
        }

        public void Draw(Graphics canvas)
        {
            if(this.Vectors != null)
            {
                foreach (var vector in this.Vectors)
                {
                    canvas.FillPolygon(vector.Brush, vector.Countour.Vertices);
                }
            }
        }

        #region IEquatable<VectorImage> Members

        public bool Equals(VectorImage other)
        {
            if (other == null)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Object Members

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
