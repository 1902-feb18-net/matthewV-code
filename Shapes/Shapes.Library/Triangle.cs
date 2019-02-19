using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    class Triangle : IShape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        //no rules for guaranteeing legal triangle

        public string Color { get; set; }

        public double getArea()
        {
            double p = (side1+side2+side3)/ 2;
            return Math.Sqrt(p * (p - side1)*(p - side2)*(p - side3));
        }

        public double getPerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
