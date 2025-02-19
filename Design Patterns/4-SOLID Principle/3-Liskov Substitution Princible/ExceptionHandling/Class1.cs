class Database
{
    public virtual void Connect()
    {
        throw new InvalidOperationException("Failed to connect to DB.");
    }
}

class SecureDatabase : Database
{
    public override void Connect()
    {
        throw new TimeoutException("Connection timed out."); // InvalidOperationException yerine onun bir alt sınıfı olan TimeoutException kullanıldı
    }
}


//wrong 

class UnstableDatabase : Database
{
    public override void Connect()
    {
        throw new StackOverflowException("Critical system failure!"); // Beklenmeyen bir istisna
    }
}
