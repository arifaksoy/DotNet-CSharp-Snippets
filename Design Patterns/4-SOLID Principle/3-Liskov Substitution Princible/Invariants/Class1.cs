//wrong
Cat myCat = new MutantCat();
Console.WriteLine(myCat.Speak()); // "Meow" beklenirken "Woof" gelir.
public class Cat
{
    public virtual string Speak() => "Meow";
}

public class MutantCat : Cat
{
    public override string Speak() => "Woof"; // Bir kedi köpek gibi ses çıkaramaz!
}


//correct

public class BigCat : Cat
{
    public override string Speak() => "Roar"; // Hala bir kedi ses çıkartıyor, LSP korunuyor.
}

