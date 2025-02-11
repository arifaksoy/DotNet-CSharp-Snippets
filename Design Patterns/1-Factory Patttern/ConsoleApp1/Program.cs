using System;

public class Database
{
    // Singleton örneğini saklamak için alan statik olarak tanımlanmalıdır
    private static Database instance;

    // Singleton'ın yapıcısı her zaman özel olmalıdır, böylece `new` operatörü ile doğrudan nesne oluşturulamaz
    private Database()
    {
        // Veritabanı sunucusuna bağlantı gibi bazı başlatma kodları.
        Console.WriteLine("Veritabanına bağlanıldı.");
    }

    // Singleton örneğine erişimi kontrol eden statik yöntem
    public static Database GetInstance()
    {
        // Eğer örnek null ise, thread kilidi almak için
        if (instance == null)
        {
            lock (typeof(Database))  // Thread kilidi al
            {
                // Örneğin başka bir thread tarafından başlatılmadığından emin ol
                if (instance == null)
                {
                    instance = new Database();  // Örneği başlat
                }
            }
        }
        return instance;
    }

    // Singleton örneği üzerinde iş mantığını çalıştırma
    public void Query(string sql)
    {
        // Bir uygulamanın tüm veritabanı sorguları bu yöntemle yapılır.
        // Burada throttling veya caching mantığı ekleyebilirsiniz.
        Console.WriteLine($"Sorgu çalıştırılıyor: {sql}");
    }
}

public class Application
{
    public static void Main()
    {
        // Singleton örneğine erişim
        Database foo = Database.GetInstance();
        foo.Query("SELECT * FROM Users");

        // `bar` değişkeni `foo` ile aynı nesneyi tutacaktır
        Database bar = Database.GetInstance();
        bar.Query("SELECT * FROM Products");
    }
}
