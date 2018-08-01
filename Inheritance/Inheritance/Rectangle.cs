using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rectangle : Shape
    {
        public Point TopLeft { get; protected set; }
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public Rectangle(Point TopLeft, double Width, double Height)
        {
            this.TopLeft = TopLeft;
            this.Width = Width;
            this.Height = Height;
            this.Name = "Rectangle";
        }
    }
}
