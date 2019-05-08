using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Library.Interfaces
{
    public interface IShape
    {
        double Getperimeter();
        double Area { get; }
        int Sides { get; }

    }
}
