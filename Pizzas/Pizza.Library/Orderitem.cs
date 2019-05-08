using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Library
{
    public class Orderitem
    {
        public string Menu { get; set; }
       /* var menu = new HashSet<Orderitem>
            {
             new Orderitem{ Menu= "Cheese Pizza" },
             new Orderitem{ Menu="Bacon Pizza " },
             new Orderitem{ Menu= "Veg Pizza" }
            };
            foreach (var item in menu)
            {
                Console.WriteLine(item.Menu);
            }*/
    public int Quantity { get; set; }

    }
}
