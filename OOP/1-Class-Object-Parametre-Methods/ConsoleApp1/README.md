# OOP Principles Example Project

This project demonstrates Object-Oriented Programming (OOP) principles through a simple car management system implemented in C#.

## About the Project

In this project, we showcase the basic principles of OOP using a Car class example. The system allows creating car objects with specific properties and simulates basic car operations.

## OOP Principles

### 1. Classes
- **Car**: Main class that represents a car object
- Contains properties and methods related to a car
- Example: `public class Car { ... }`

### 2. Properties (Fields/Attributes)
- **Brand**: Car's manufacturer
- **Model**: Car's model name
- **Year**: Manufacturing year
- Properties use C# auto-implemented properties: `public string Brand { get; set; }`

### 3. Objects (Instances)
- Created from the Car class
- Example: `Car myCar = new Car("Toyota", "Corolla", 2023);`
- Multiple instances can be created: 
  ```csharp
  Car myCar = new Car("Toyota", "Corolla", 2023);
  Car yourCar = new Car("Tofaş", "Tofaş", 2000);
  ```

### 4. Constructor
- Special method for object initialization
- Takes parameters: brand, model, and year
- Example:
  ```csharp
  public Car(string brand, string model, int year)
  {
      Brand = brand;
      Model = model;
      Year = year;
  }
  ```

### 5. Methods
- **StartEngine()**: Simulates starting the car
- Methods can use object's properties
- Example output: "Toyota Corolla has started!"

### 6. Parameters
- Values passed to constructors and methods
- Used to initialize object properties
- Allows for customization of object behavior

## Project Structure 