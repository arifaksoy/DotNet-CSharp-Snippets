# C# Access Modifiers Demo

This project demonstrates the various access modifiers available in C# and their usage through a simple animal hierarchy example. The project helps developers understand how different access levels work in C# and when to use them.

## Access Modifiers Explained

C# provides six different access modifiers that control the visibility and accessibility of types and type members:

1. **Public** (`public`)
   - Accessible from anywhere
   - No restrictions on access
   - Example: Public methods like `DisplayInfo()` in the Animal class

2. **Private** (`private`)
   - Accessible only within the declaring class
   - Provides the highest level of encapsulation
   - Example: Private fields like age in the Animal class

3. **Protected** (`protected`)
   - Accessible within the declaring class and all derived classes
   - Useful for inheritance scenarios
   - Example: Protected members that need to be accessed by derived classes like Dog and Cat

4. **Internal** (`internal`)
   - Accessible only within the same assembly
   - Default access modifier for classes
   - Example: Internal methods that should only be used within the project

5. **Protected Internal** (`protected internal`)
   - Accessible within the same assembly AND from derived classes
   - Combines the access levels of protected and internal
   - Can be accessed by derived classes in other assemblies

6. **Private Protected** (`private protected`)
   - Accessible only within the same assembly AND in derived classes within that assembly
   - Most restrictive combination of protected and internal
   - Available since C# 7.2

## Project Structure

The project consists of several classes demonstrating these access modifiers:

- `Animal`: Base class with various members using different access modifiers
- `Dog`: Derived class showing inheritance and access modifier behavior
- `Cat`: Another derived class demonstrating access modifier inheritance

## Usage Example

```csharp
// Creating an Animal instance
Animal animal = new Animal("Lion", 5, "Panthera leo");

// Accessing public members
animal.DisplayInfo();  // ✓ Accessible from anywhere

// The following would cause compilation errors:
animal.age;           // ✗ Cannot access private member
animal.species;       // ✗ Cannot access protected member
animal.UpdateAge();   // ✗ Cannot access private method
```

## Best Practices

1. Use the most restrictive access level possible
2. Make fields private and provide public properties when needed
3. Use protected for members that derived classes need to access
4. Use internal for types that should only be accessible within your assembly
5. Consider using private protected when you want to restrict access to derived classes within the same assembly

## Requirements

- .NET Core 3.1 or higher
- Any C# IDE (Visual Studio, VS Code, Rider)

## Running the Project

1. Clone the repository
2. Open the solution in your preferred IDE
3. Build and run the project
4. Observe the console output demonstrating various access modifier behaviors
