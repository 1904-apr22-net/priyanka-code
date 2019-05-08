using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaapp.Library
{
    public class Order:Ipizza
    {
        float total;
       public Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"smallpizza"},
                                                                {2, "mediumpizza"},
                                                                {3,"largepizza"}
                                                            };
        public void Customer()
        {
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            public double CalculateTotal()
            {
                double total = 0;
                foreach (var item in dict)
                {
                    var pizzaId = item.Key;
                    var quantity = item.Value;

                    if (pizzaId == 1)
                    {
                        total += quantity * 5;
                    }
                    else if (pizzaId == 2)
                    {
                        total += quantity * 10;
                    }
                    else
                    {
                        total += quantity * 15;
                    }
                }
                return 1.08 * total;
            }
            // int quantity;
            //Console.WriteLine("How many ");
            // o=DateTime.Now;
            // Console.WriteLine();
            // DateTime a = DateTime.Now;
            // Console.WriteLine(a.ToString("MM/dd/yyyy HH:mm:ss"));  
            /*public float Total(int q,int price)
             {
                 return total = q * 0.08 *price;
             }*/
        }
    }
}

    

