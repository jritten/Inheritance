using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Circle : Shape
    {
        public Point Center { get; protected set; }
        public double Radius { get; protected set; }
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
  
        public Circle (Point p, double radius)
        {
            Center = p;
            Radius = radius;
            Name = "Circle";
        }
    }
}
