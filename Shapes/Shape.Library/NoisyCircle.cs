using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Library
{
    public class NoisyCircle:BetterCircle

    {
        public override double radius
        {
            get
            {
                Console.WriteLine("getting");
                return _radius;
            }
            set
            {
                Console.WriteLine("setting");
                _radius = value;
            }

        }
        public override double Area
        {
            get
            {
                Console.WriteLine("area");
               return base.Area;

            }
        }
        public new double Getperimeter()
        {
            Console.WriteLine("perimeter");
            return base.Getperimeter();
        }



    }
}
