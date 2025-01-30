using System;

namespace Business
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age, "Canis lupus familiaris")
        {
            Breed = breed;
            // Can access protected members
            species = "Dog";
            
            // Can access protected internal members
            habitat = "Domestic";
            
            // Can access private protected members within the same assembly
            weight = 20;
        }

        public void DogInfo()
        {
            // Can access public members
            Console.WriteLine($"Name: {Name}");
            
            // Can access protected members
            Console.WriteLine($"Species: {species}");
            
            // Can access internal members
            Console.WriteLine($"Is Wild: {isWild}");
            
            // Can access protected internal members
            Console.WriteLine($"Habitat: {habitat}");
            
            Console.WriteLine($"Breed: {Breed}");
        }
    }
} 