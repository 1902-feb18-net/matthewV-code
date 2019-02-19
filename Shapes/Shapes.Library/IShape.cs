using System;

namespace Shapes.Library
{
    public interface IShape
    {
        double getArea();
        double getPerimeter();
        string Color { get; set; }
       

    }
}
