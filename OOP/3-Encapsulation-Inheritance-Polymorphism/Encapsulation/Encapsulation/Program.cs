using System;

public class Person
{
    // Encapsulation: We prevented external access by making the data private.
    private string name;

    // We access private data with the public method.
    public void SetName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            this.name = name;
        }
    }

    public string GetName()
    {
        return name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.SetName("Arif");  // We use the setter method to access encapsulated data.
        Console.WriteLine("Person Name: " + person.GetName());  // We get the data with the getter method.
    }
}
