using Shape.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Library
{
    public class BetterCircle:IShape

    {
        public int Sides => 1;
        public double X { get; set; }
        public double Y { get; set; }
        protected double _radius;
            public virtual double radius
        {
            get
            {
                return _radius * 1.01;
            }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                     _radius=value;
                }
            }
        }
        public double Getperimeter() => 2 * Math.PI * radius;
        public virtual double Area => Math.PI * radius * radius;

    }
}
