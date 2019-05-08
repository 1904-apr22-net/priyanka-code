using Anima.Library;
using System;

namespace Anima.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Breed = "lab";
            dog.Name = "la";
            dog.Bark();
            Console.WriteLine("Hello World!");
        }
    }
}
