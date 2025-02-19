public class Animal { }
public class Cat : Animal { }
public class BengalCat : Cat { }

class CatStore
{
    public virtual Cat BuyCat()
    {
        return new Cat();
    }
}

class BengalCatStore : CatStore
{
    public override BengalCat BuyCat() // BengalCat, Cat'in alt sınıfı olduğu için geçerli
    {
        return new BengalCat();
    }
}

//wrong
class GenericAnimalStore : CatStore
{
    public override Animal BuyCat() // Dönüş tipi daha genel hale getirildi
    {
        return new Animal(); // İstemci bir "Cat" bekliyor ama "Animal" alıyor!
    }
}

