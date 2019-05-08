using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Library
{
   public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int Sides => 4;
        public double Getperimeter()
        {
            return 2*Length+2*Width;
        }
        public double Areas => Length * Width;

      //  public double Areas() => Length * Width;
        
           
        
    }
}
