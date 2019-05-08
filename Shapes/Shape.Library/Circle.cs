using System;

namespace Shape.Library
{
    public class Circle
    {
        private double radius;
        public double Getradius()
        {
            return radius * 1.01;
        }
        public void Setradius(double radius)
        {
            if(radius<0)
            {
                Console.WriteLine("not allowed");
            }
            else
            {
                this.radius = radius;
            }
        }
        

        
     }
    
}
