using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Square : Rectangle
    {
        public Square (Point topLeft, double length) : base(topLeft, length, length)
        {
            Name = "Square";
        }
    }
}
