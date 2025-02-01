using System;

public class Car
{
    // 🛠 Properties (Fields / Attributes)
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // 🏁 Constructor
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // 🚗 Method - Simulates starting the car
    public void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model} has started!");
    }
}

// 🏎 Program Execution
class Program
{
    static void Main()
    {
        // 🔥 Creating an object (Instance)
        Car myCar = new Car("Toyota", "Corolla", 2023);

        // 🚀 Calling the method
        myCar.StartEngine(); // Output: "Toyota Corolla has started!"

        Car yourCar = new Car("tofaş", "tofaş", 2000);

        yourCar.StartEngine();
    }
}