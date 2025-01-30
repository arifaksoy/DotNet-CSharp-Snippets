using Business;
using System;

public class MainClass : Animal
{
    public MainClass () :base("Lion", 5, "Panthera leo")
    { }
	public void RunAnimalProtectedMethod()
	{
        // Creating an Animal instance
        Animal animal = new Animal("Lion", 5, "Panthera leo");

        animal.SetWildStatus(true);

        //we cannot access it because it is private protected. this class is in another project.
        weight=20;

        // we can access it because it is protected internal. this class derived animal class.
        habitat = "dasd";
    }
}
