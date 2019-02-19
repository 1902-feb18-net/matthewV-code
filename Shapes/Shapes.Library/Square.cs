using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    class Square : Rectangle
    {
        public double side { get; set; }

        public override double length { get => side; set { side = value; } }
        public override double width  { get => side; set { side = value; } }

        public override double getArea()
        {
            return (2 * side);
        }

        public override double getPerimeter()
        {
            return (4 * side);
        }

    }
}
