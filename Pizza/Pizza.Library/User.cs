using System;
using System.Collections.Generic;

namespace Pizza.Library
{
    public class User
    {
       // Order o = new Order();
        public void Customer()
        {
            //var name = new System.Collections.Generic.List<string> { };
            Console.WriteLine("Enter first name");
            var fname = Console.ReadLine();
            //Console.WriteLine("fname is"+ fname);
            Console.WriteLine("Enter last name");
            var lname= Console.ReadLine();
            //var name = fname + lname;
            Console.WriteLine("name is " +fname+" "+lname);
            Console.WriteLine("Store Locations are:");
            var store = new HashSet<string> {"Lewisville","Hebron","Carrolton" };
            foreach(var item in store)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Select the store location");
            var d = Console.ReadLine();
            Console.WriteLine("Store location is " + d);
           
            //Order();
            /*if(store=="lewisville")
            {

            }*/

            //string c=store.Add();
            /*var c = Console.ReadLine();
            store.Add(c);
            foreach(var item in store)
            {
                Console.WriteLine(item);
            }
            
            */









        }
       /* public void Order()
        {
            Console.WriteLine("Select the store location");
           var d=Console.ReadLine();
            Console.WriteLine("Store location is "+d);
            //Customer();
            //
          //  Console.WriteLine("Customer name is"+fname.Customer());

        }
        */
    }
}
