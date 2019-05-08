using Pizza.Library;
using System;
using System.Collections.Generic;

namespace Pizzas.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //double tax = 0.08;
            Customer c = new Customer();
            Location l = new Location();
            Order order = new Order();
            Orderitem oi = new Orderitem();
            Console.WriteLine("Enter firstname");
            c.fname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            c.lname = Console.ReadLine();
            Console.WriteLine("Name is " + c.fname + " " + c.lname);
            Console.WriteLine("Locations of the store are:");
            var locations = new HashSet<Location>
            {
                new Location { Name = "lewisville" },
                new Location { Name = "Plano" },
                new Location { Name = "Frisco" }
            };
            foreach (var item in locations)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Choose the store");
            l.Name = Console.ReadLine();
            Console.WriteLine("Store is " +l.Name);
            Console.WriteLine("Menu available for"+l.Name);
            //Console.WriteLine("");
            var menu = new HashSet<Orderitem>
            {
             new Orderitem{ Menu= "Cheese Pizza" },
             new Orderitem{ Menu="Bacon Pizza " },
             new Orderitem{ Menu= "Veg Pizza" }
            };
            foreach (var item in menu)
            {
                Console.WriteLine(item.Menu);
            }
            Console.WriteLine("Choose the item from store");
            oi.Menu = Console.ReadLine();
            Console.WriteLine("Order is " + oi.Menu);
            order.CalculateTotal();
            /*Console.WriteLine("Pizza size is:");
            var sizes = new List<string> { "medium", "small", "large" };
            foreach(var size in sizes)
            {
                Console.WriteLine(size);
            }
            Console.WriteLine("Enter the size of pizza");
            string b = Console.ReadLine();
            Console.WriteLine("Prices are:");
            float large = 15;
            float small = 5;
            float medium = 10;
            
            Console.WriteLine("Large pizza "+large);
            Console.WriteLine("Small pizza " + small);
            Console.WriteLine("Medium pizza " + medium);*/
            //float price = float.parse(Console.ReadLine());
            Console.WriteLine("how many item do you require "+c.fname);
            int quan = int.Parse(Console.ReadLine());
            Console.WriteLine(b +' '+ oi.Menu+" ordered is "+quan);
            order.CalculateTotal();
            Console.WriteLine("Total"+order.CalculateTotal());
           //float total= o.Total(quan,price);
            DateTime a = DateTime.Now;
            c.Time = a;
            Console.WriteLine(a.ToString("MM/dd/yyyy HH:mm:ss"));
            /*Console.WriteLine("Number of item required");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of item required are "+d);*/
        }
    }
}
