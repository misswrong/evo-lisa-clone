using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class ColoredTriangle
    {
        private Point[] vertices;
        
        public Point[] Vertices 
        { 
            get
            {
                return this.vertices;
            }
            set
            {
                this.vertices = value;
            }
        }
    }
}