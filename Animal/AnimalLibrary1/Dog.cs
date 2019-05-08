using System;


namespace AnimalLibrary1
{
    public class Dog
    {
        public string Breed { get; set; }
        public string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
}
