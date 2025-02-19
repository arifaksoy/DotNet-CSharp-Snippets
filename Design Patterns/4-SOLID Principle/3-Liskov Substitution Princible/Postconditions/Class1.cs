//wrong 

 void DoWork(DatabaseConnection db)
{
    db.Close(); // Beklenen: Bağlantının kapanması. Ancak PersistentDatabaseConnection ile kapanmaz.
}

DoWork(new PersistentDatabaseConnection()); // LSP ihlali!


public class DatabaseConnection
{
    public virtual void Close()
    {
        Console.WriteLine("Bağlantı kapatıldı.");
    }
}

public class PersistentDatabaseConnection : DatabaseConnection
{
    public override void Close()
    {
        Console.WriteLine("Bağlantıyı kapatmıyorum çünkü tekrar kullanacağım.");
    }
}



public class PersistentDatabaseConnection2 : DatabaseConnection
{
    public override void Close()
    {
        base.Close(); // Temel sınıfın davranışını koruyor.
        Console.WriteLine("Bağlantıyı tekrar açabilirim.");
    }
}

