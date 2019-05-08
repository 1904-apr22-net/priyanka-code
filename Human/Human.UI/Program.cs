using Human.Library;
using System;

namespace Human.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            man.country = "a";
            man.nature();
            Console.WriteLine("Hello World!");
            // Console.WriteLine("It is " + man.country);
            Console.WriteLine(""+man.country);
        }
    }
}
