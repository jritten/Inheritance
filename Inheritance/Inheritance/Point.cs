using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            var input = obj as Point;
            if (input == null)
            {
                return false;
            }
            if (this.Name == input.Name)
            {
                return true;
            }
            return false;
        }
    }
}
