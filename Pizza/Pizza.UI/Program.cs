using Pizza.Library;
using System;
using System.Collections.Generic;

namespace Pizza.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Customer();
            Order o = new Order();
            o.Menu();
            Product p = new Product();
            p.Time();
            Totalprice t = new Totalprice();
            t.total();
           // Order o = new Order();
           // u.Order();
            

            //bool c = true;
           /* Console.WriteLine("Welcome to Pizza World");
            while (true)
            {
                //Console.WriteLine("1. Owner");
                Console.WriteLine("1. Customer Login");
                Console.WriteLine("2. New Customer");
                Console.WriteLine("3.Place an order");

                var value = Console.ReadLine();
                if (value == "1")
                {
                    Console.WriteLine("username");
                    var a = Console.ReadLine();
                    Console.WriteLine("password");
                    var b = Console.ReadLine();
                    Console.WriteLine("Authenticated");
                }
                if (value == "2")
                {
                    Console.WriteLine("username");
                    var a = Console.ReadLine();
                    Console.WriteLine("password");
                    var b = Console.ReadLine();
                    Console.WriteLine("Authenticated");
                }
                if (value == "3")
                {
                    Console.WriteLine("Place an order");

                    Console.WriteLine("1. Cheese Pizza");
                    Console.WriteLine("2. Bacon Pizza");
                    Console.WriteLine("3. Dossa Pizza");
                    var order = Console.ReadLine();
                    if (order == "1")
                    {
                        Console.WriteLine("Order is Cheese pizza");
                        Console.WriteLine("1.Pizza size is small");
                        Console.WriteLine("2.Pizza size is medium");
                        Console.WriteLine("3.Pizza size is large");


                    }

                    if (order == "2")
                    {
                        Console.WriteLine("Order is Bacon pizza");
                        Console.WriteLine("1.Pizza size is small");
                        Console.WriteLine("2.Pizza size is medium");
                        Console.WriteLine("3.Pizza size is large");
                    }
                    if (order == "3")
                    {
                        Console.WriteLine("Order is Dossa pizza");
                        Console.WriteLine("1.Pizza size is small");
                        Console.WriteLine("2.Pizza size is medium");
                        Console.WriteLine("3.Pizza size is large");
                    }
                    var size = Console.ReadLine();
                    if (size == "1")
                    {
                        Console.WriteLine("Pizza size is Small and cost is $7");
                    }
                    if (size == "2")
                    {
                        Console.WriteLine("Pizza size is medium and cost is $10");
                    }
                    if (size == "3")
                    {
                        Console.WriteLine("Pizza size is large and cost is $15");
                    }

                }
                
            }
           // c != true;



            /*Console.WriteLine("1. New Customer");
            Console.WriteLine("2. Place an order");
            //Console.WriteLine("3. Place an order");
            var input = Console.ReadLine();
            if(input=="1")
            {
                Console.WriteLine("Add the name");
                var Newcustomer = new List<String> { "Priya","manu" };

                Newcustomer.Add(Console.ReadLine());
               /* foreach(var item in Newcustomer)
                {
                    Console.WriteLine(item);

             }*/
            /*Console.WriteLine("Welcome"+Newcustomer[0]);
                if (input == "2")
                {
                    Console.WriteLine("Please place the order");
                    //var order = new List<int> { };

                    Console.WriteLine("1. Cheese Pizza");
                    Console.WriteLine("2. Bacon Pizza");
                    Console.WriteLine("3. Dossa Pizza");
                    var order = Console.ReadLine();
                    //order.Add(Console.ReadLine());

                }

            }*/


            //Console.WriteLine("Welcome to PizzaWorld");



            /* var customer[] = new List<string> {"" };

             {
                 customer[i]=
             }*/
        }
        
    }
}
