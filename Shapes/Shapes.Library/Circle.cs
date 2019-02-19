using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    class Circle :  IShape
    {
        const double PI = 3.14;

        public double Radius { get; set; }
        public string Color { get; set; }

        public double getArea()
        {
            return PI * Radius * Radius; 
        }

        public double getPerimeter()
        {
            return 2 * PI * Radius ;    
            
        }

        public double getCircumference()
        {
            return 2 * PI * Radius;

        }
    }
}
