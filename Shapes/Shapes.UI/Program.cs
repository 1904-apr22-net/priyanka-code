using Shape.Library;
using System;

namespace Shapes.UI
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Circle cir = new Circle();
            double r=cir.Getradius();
            cir.Setradius(-4);
            BetterCircle b = new BetterCircle();
            b.radius = 5;
            Console.WriteLine("hello");
            // Console.WriteLine("shape"+b.radius);
            // Console.WriteLine("shape" + b.Getperimeter());*/
            shapework();
        }
        static void shapework()
        {
            Rectangle c = new Rectangle();
            Console.WriteLine("enter length");
            c.Length = int.Parse(Console.ReadLine());
            c.Width = 3;
            Console.WriteLine(c.Getperimeter());
            Console.WriteLine(c.Areas);
            NoisyCircle ns = new NoisyCircle();
            ns.Getperimeter();
            ColoredCircle cc = new ColoredCircle();
            PrintDetails(c,"rectangle");
            PrintDetails(cir,"circle");
           // cc.color;
        }
        static void PrintDetails(IShape shape,string name)
        {
            Console.WriteLine("Area is"+shape.Area);
            Console.WriteLine("Perimeter is " + shape.GetPerimeter());
            Console.WriteLine("Sides is " + shape.Sides);
        }
    }
}
