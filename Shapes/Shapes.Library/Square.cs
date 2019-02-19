using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    class Square : Rectangle
    {
        public double side { get; set; }
        //no rules for guaranteeing legal square, based off inherited fields length and width from Rectangle

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
