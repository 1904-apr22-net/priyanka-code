using Anim.Library;
using System;

namespace Anim.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name="he";
            dog.breed="lab";
            dog.bark();
            Console.WriteLine("Hello World!");
        }
    }
}
