// See https://aka.ms/new-console-template for more information
Console.WriteLine("Basic Singleton");
var basSing1 = BasicSingletonPattern.GetInstance();
var basSing2 = BasicSingletonPattern.GetInstance();
Console.WriteLine(basSing1.GetHashCode());
Console.WriteLine(basSing2.GetHashCode());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Thread Safe Singleton");
var tsSing1 = ThreadSafeSingletonPattern.GetInstance();
var tsSing2 = ThreadSafeSingletonPattern.GetInstance();
Console.WriteLine(tsSing1.GetHashCode());
Console.WriteLine(tsSing2.GetHashCode());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Lazy Singleton");
var lazySing1 = LazySingletonPattern.Instance;
var lazySing2 = LazySingletonPattern.Instance;
Console.WriteLine(lazySing1.GetHashCode());
Console.WriteLine(lazySing2.GetHashCode());


public class BasicSingletonPattern
{
    private static BasicSingletonPattern _instance;

    private BasicSingletonPattern() { }

    public static BasicSingletonPattern GetInstance() 
    {
        if (_instance == null)
        {
            _instance = new BasicSingletonPattern();
        }
        return _instance; 
    }
}

public class ThreadSafeSingletonPattern
{
    private static ThreadSafeSingletonPattern _instance;
    private static readonly object obj =new object(); // this lock object

    private ThreadSafeSingletonPattern() { }

    public static ThreadSafeSingletonPattern GetInstance()
    {
        if (_instance == null)
        {
            lock (obj) // this is thread lock.
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingletonPattern();
                }
            }
            
        }
       
        return _instance;
    }
}

public class LazySingletonPattern
{
    private static readonly Lazy<LazySingletonPattern> _instance = new Lazy<LazySingletonPattern>(()=>new LazySingletonPattern());

    private LazySingletonPattern() { }

    public static LazySingletonPattern Instance = _instance.Value;

}


