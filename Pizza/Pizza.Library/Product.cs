using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Library
{
    public class Product:User
    {
        public void Time()
        {
            Console.WriteLine("The store is from 10am to 9pm from Monday to Friday");
            Console.WriteLine("The store is from 10am to 11pm on Saturday to Sunday");

        }
    }
}
