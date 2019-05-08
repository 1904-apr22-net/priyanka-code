using Pizza.Library.Interface;
using System;

namespace Pizza.Library
{
    public class Customer
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime Time { get; set; }

        // customer.Time = DateTime.Now;
        
          
        /*DateTime a = DateTime.Now;
        Console.WriteLine(a.ToString("MM/dd/yyyy HH:mm:ss"));
       /* public double GetBill()
        {
            int quantity = int.Parse(Console.ReadLine());
            //int total = quantity * 10 + 0.08;
           // return total;

        }*/

    }
}
