using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    class Rectangle : IShape
    {
        public double length { get; set; }
        public double width { get; set; }

        public string Color { get; set; }

        public virtual double getArea()
        {
            return length * width;
        }

        public virtual double getPerimeter()
        {
            return (2 * length) + (2 * width);
        }
    }
}
