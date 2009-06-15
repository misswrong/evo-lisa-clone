using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class BitmapCloner
    {
        public VectorDrawing Clone(Bitmap bitmap, long distance)
        {
            var parent = VectorDrawingGenetics.Instance.Create(bitmap.Width, bitmap.Height, 1);
            var parentDistance = VectorDrawingGenetics.Instance.CalculateDistance(parent, bitmap);
            while (parentDistance > distance)
            {
                var child = VectorDrawingGenetics.Instance.Mutate(parent, bitmap.Width, bitmap.Height);
                var childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                if (childDistance < parentDistance)
                {
                    parent = child;
                    parentDistance = childDistance;
                }
            }
            return parent;
        }
    }
}
