

//non Interface Segregation Princible
public interface CloudProvider
{
    void StoreFile(string name);

    void GetFile(string name);

    void CreateServer();

    void ListServers();

    void GetCDNAddress();

}

public class Amozon : CloudProvider
{
    public void CreateServer()
    {
        Console.WriteLine("Creating servers");
    }

    public void GetCDNAddress()
    {
        Console.WriteLine("Get CDN Address");
    }

    public void GetFile(string name)
    {
        Console.WriteLine("Getting file");
    }

    public void ListServers()
    {
        Console.WriteLine("Listing servers");
    }

    public void StoreFile(string name)
    {
        Console.WriteLine("Storing File");
    }
}

public class DropBox : CloudProvider
{
    public void CreateServer()
    {
        throw new NotImplementedException();
    }

    public void GetCDNAddress()
    {
        throw new NotImplementedException();
    }

    public void GetFile(string name)
    {
        Console.WriteLine("Getting file");
    }

    public void ListServers()
    {
        throw new NotImplementedException();
    }

    public void StoreFile(string name)
    {
        Console.WriteLine("Storing File");
    }
}



//Interface Segregation Princible

public interface CloudHostingProvider
{
    void CreateServer();

    void ListServers();
}

public interface CDNProvider
{
    void GetCDNAddress();
}

public interface CloudStorageProvider
{
    void StoreFile(string name);
    void GetFile(string name);
}

public class Amozon2 : CloudHostingProvider,CDNProvider,CloudStorageProvider
{
    public void CreateServer()
    {
        Console.WriteLine("Creating servers");
    }

    public void GetCDNAddress()
    {
        Console.WriteLine("Get CDN Address");
    }

    public void GetFile(string name)
    {
        Console.WriteLine("Getting file");
    }

    public void ListServers()
    {
        Console.WriteLine("Listing servers");
    }

    public void StoreFile(string name)
    {
        Console.WriteLine("Storing File");
    }
}

public class DropBox2 : CloudStorageProvider
{
    public void GetFile(string name)
    {
        Console.WriteLine("Getting file");
    }

    public void StoreFile(string name)
    {
        Console.WriteLine("Storing File");
    }
}
