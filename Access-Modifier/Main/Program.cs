using System;
using Business;

namespace AccessModifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access Modifier Demo Application");
            Console.WriteLine("-------------------------------");

            // Creating an Animal instance
            Animal animal = new Animal("Lion", 5, "Panthera leo");

            // Accessing public members
            Console.WriteLine("\nAccessing public members:");
            animal.DisplayInfo();

            // Can access internal members because we are in the same assembly
            animal.SetWildStatus(true);

            Console.WriteLine("\nDog Example:");
            // Creating a Dog instance
            Dog dog = new Dog("Buddy", 3, "Golden Retriever");
            dog.DogInfo();

            // The following lines would cause compilation errors if uncommented:
            // animal.age;        // Cannot access private member
            // animal.species;    // Cannot access protected member
            // animal.UpdateAge(); // Cannot access private method

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}