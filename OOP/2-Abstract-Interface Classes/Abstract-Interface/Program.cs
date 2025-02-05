using System;

// Abstract class example
public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Run();
    

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    // Abstract method
    public abstract void MakeSound();
}

// Dog class, derived from Animal class
public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }

    public override void Run()
    {
        Console.WriteLine("dog is running.");
    }
}

public class Bird : Dog
{
    public Bird(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }

    //public override void Run()
    //{
    //    Console.WriteLine("bird is running.");
    //}
}

// Cat class, derived from Animal class
public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
    public override void Run()
    {
       Console.WriteLine("cat is running");
    }
}

// Interface example
public interface IAnimal
{
    void MakeSound();
}

// Dog class, implements the IAnimal interface
public class DogWithInterface : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Cat class, implements the IAnimal interface
public class CatWithInterface : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using abstract class
        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Whiskers");

        Console.WriteLine($"{dog.Name}:");
        dog.MakeSound();
        dog.Sleep();
        dog.Run();

        Console.WriteLine($"{cat.Name}:");
        cat.MakeSound();
        cat.Sleep();
        cat.Run();

        // Using interface
        IAnimal dogWithInterface = new DogWithInterface();
        IAnimal catWithInterface = new CatWithInterface();

        Console.WriteLine("\nUsing interfaces:");
        dogWithInterface.MakeSound();
        catWithInterface.MakeSound();

        var bird = new Bird("twity");

        bird.Run();



        Console.ReadLine();
    }
}
