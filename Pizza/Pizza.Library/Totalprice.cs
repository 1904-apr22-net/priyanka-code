using Pizza.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Library
{
    public class Totalprice : IPizza
    {
        int d =int.Parse(Console.ReadLine());
        public float total()
        {
           
            return 10 * d;
        }
    }
}
