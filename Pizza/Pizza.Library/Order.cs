using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Library
{
    public class Order:User
    {

        public void Menu()
        {
            // u.Customer();
            Console.WriteLine("Choose a Pizzas from:");
            Console.WriteLine("1.Cheese Pizza");
            Console.WriteLine("2.Bacon Pizza");
            Console.WriteLine("3.Veg Pizza");
            var b = Console.ReadLine();
            Console.WriteLine("Ordered pizza is " + b);
            Console.WriteLine("How many you require?");
            int d = int.Parse(Console.ReadLine());
            
        }
        /*public float Total()
        {
            int c = d;
            float total = d * 10.5;
            float tax = 8.5;
        }*/
            /*Console.WriteLine("Anything else?Yes or No");
            var c = Console.ReadLine();
            if (c == 'yes')
            {

            }
            else
            {

            }*/
        }
        /*public void ConfirmOrder()
        {
            Console.WriteLine("");
        }
        */
    }


