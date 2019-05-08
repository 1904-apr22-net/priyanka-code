using Addition.Library;
using System;

namespace Addition.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int p=3, q=2, c;
            Add add = new Add();
            c=add.sum(p,q);
            Console.WriteLine("Numbers is"+ c);
            //add.name="abc";
            //Console.WriteLine(add.name);
        }
    }
}
