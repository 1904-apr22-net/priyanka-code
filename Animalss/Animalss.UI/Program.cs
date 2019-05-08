using Animalss.Library;
using System;

namespace Animalss.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Cat cat1 = new Cat();
            cat.Name="aa";
            cat.Breed="bb";
            cat.Bark();
            cat1.Name = "hiii";
            cat1.Breed = "bb";
            cat1.Bark();
            Console.WriteLine("Hello World!");
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat1.Name);
        }
    }
}
