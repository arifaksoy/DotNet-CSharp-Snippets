using System;

class Animal
{
    public virtual void MakeSound()  // virtual metod
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()  // override edilen metod
    {
        Console.WriteLine("Woof Woof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.MakeSound();  // Animal sound

        Animal myDog = new Dog();  // Polymorphism: Referans tipi Animal, nesne tipi Dog
        myDog.MakeSound();  // Woof Woof
    }
}
