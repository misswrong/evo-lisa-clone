using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class DrawnPolygon:IEquatable<DrawnPolygon>
    {
        public Polygon Countour { get; set; }
        public Brush Brush { get; set; }

        #region IEquatable<DrawnPolygon> Members

        public bool Equals(DrawnPolygon other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Brush == other.Brush && this.Countour == other.Countour;
        }

        #endregion

        #region Object Members

        public override bool Equals(object obj)
        {
            var other = obj as DrawnPolygon;
            if (other == null)
            {
                return false;
            }
            return this.Equals(other);
        }

        public override int GetHashCode()
        {
            if (this.Brush == null)
            {
                if (this.Countour == null)
                {
                    return 0;
                }
                return this.Countour.GetHashCode();
            }
            if (this.Countour == null)
            {
                return this.Brush.GetHashCode();
            }
            return this.Brush.GetHashCode() + this.Countour.GetHashCode();
        }

        #endregion
    }
}
