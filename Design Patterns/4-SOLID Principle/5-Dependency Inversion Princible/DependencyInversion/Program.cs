


public class MongoDB
{
    public void Insert()
    {
        //insert data
    }

    public void Update()
    {
        //update data
    }

    public void Delete()
    {
        //delete data
    }
}

public class MySQLDatabase
{
    public void Insert()
    {
        //insert data
    }

    public void Update()
    {
        //update data
    }

    public void Delete()
    {
        //delete data
    }
}

public class BudgetReport
{
    public void save()
    {
        var database = new MySQLDatabase();
        database.Update();
    }
}



//Dependency Inversion

public interface Database
{
    public void Insert();

    public void Update();

    public void Delete();
  
}


public class MongoDB2:Database
{
    public void Insert()
    {
        //insert data
    }

    public void Update()
    {
        //update data
    }

    public void Delete()
    {
        //delete data
    }
}

public class MySQLDatabase2 : Database
{
    public void Insert()
    {
        //insert data
    }

    public void Update()
    {
        //update data
    }

    public void Delete()
    {
        //delete data
    }
}

public class BudgetReport2
{
    private readonly Database _database;

    public BudgetReport2(Database database)
    {
        _database = database;
    }
    public void save()
    {
        _database.Update();
    }
}

