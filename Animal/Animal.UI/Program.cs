using Animal.Library1;
using System;

namespace Animal.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name="lab";
            dog.Breed="hi";
            dog.Bark();
            Console.WriteLine("Hello World!");
        }
    }
}
