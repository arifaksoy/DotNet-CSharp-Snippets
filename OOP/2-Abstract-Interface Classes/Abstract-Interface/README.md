# Abstract Classes vs Interfaces in C#

## Abstract Classes

Abstract classes in C# serve as base classes that cannot be instantiated on their own. They are used to define a common base with shared functionality for derived classes.

### Key Characteristics of Abstract Classes:

1. **Partial Implementation**: Abstract classes can contain both implemented methods and abstract methods
   - Implemented methods: Like `Sleep()` and `Run()` in the `Animal` class
   - Abstract methods: Like `MakeSound()` which must be implemented by derived classes

2. **Constructor Support**: Can have constructors
   ```csharp
   public Animal(string name)
   {
       Name = name;
   }
   ```

3. **State Management**: Can have fields and properties
   ```csharp
   public string Name { get; set; }
   ```

4. **Access Modifiers**: Can have different access modifiers (public, private, protected)

## Interfaces

Interfaces define a contract that implementing classes must follow. They only declare the members that the implementing classes must implement.

### Key Characteristics of Interfaces:

1. **No Implementation**: Only method signatures, no implementation
   ```csharp
   public interface IAnimal
   {
       void MakeSound();
   }
   ```

2. **Multiple Implementation**: A class can implement multiple interfaces
3. **No State**: Cannot contain fields
4. **No Constructor**: Cannot have constructors

## When to Use What?

### Use Abstract Classes When:
- You want to share code among several related classes
- You have common functionality that derived classes can inherit
- You need to declare non-public members
- You want to provide a base class that requires constructor parameters
- Classes that inherit from it have a lot in common

Example from the code:
```csharp
public abstract class Animal
{
    // Shared property
    public string Name { get; set; }
    
    // Shared implemented method
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
    
    // Abstract method that must be implemented
    public abstract void MakeSound();
}
```

### Use Interfaces When:
- You want to define a contract that multiple unrelated classes can implement
- You need to support multiple inheritance
- You want to specify the behavior but not the implementation
- You want to separate the definition of a service from its implementation

Example from the code:
```csharp
public interface IAnimal
{
    void MakeSound();
}
```

## Key Differences

1. **Multiple Inheritance**:
   - Classes can inherit from only one abstract class
   - Classes can implement multiple interfaces

2. **Implementation**:
   - Abstract classes can have implemented methods and fields
   - Interfaces can only have method declarations (prior to C# 8.0)

3. **Constructor**:
   - Abstract classes can have constructors
   - Interfaces cannot have constructors

4. **Access Modifiers**:
   - Abstract classes support access modifiers
   - Interface members are always public

5. **State**:
   - Abstract classes can have fields and properties with state
   - Interfaces cannot have fields (state) 