public class Animal { }
public class Cat : Animal { }
public class BengalCat : Cat { }

public class Feeder
{
    public virtual void Feed(Cat cat)
    {
        Console.WriteLine("Feeding a cat...");
    }
}

public class UniversalFeeder : Feeder
{
    public override void Feed(Animal animal) // Daha soyut hale getirdik (Animal, Cat'in üst sınıfıdır)
    {
        Console.WriteLine("Feeding an animal...");
    }
}


// wrong

class BengalFeeder : Feeder
{
    public override void Feed(BengalCat cat) // Daha spesifik bir tipe indirgendi
    {
        Console.WriteLine("Feeding a Bengal cat...");
    }
}
