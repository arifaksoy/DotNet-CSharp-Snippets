var nonOpenClosedPrincibleEmployee = new NonOpenClosedPrincibleEmployee();
nonOpenClosedPrincibleEmployee.GetEmployeeInfo(EmployeeType.Manager);

Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");

var employee = new Employee();
employee.GetEmployeeInfo(new Developer());



public enum EmployeeType
{
    Manager,
    Developer,
    HumanResources
}
public class NonOpenClosedPrincibleEmployee
{
    public void GetEmployeeInfo(EmployeeType employeeType)
    {
        if(employeeType == EmployeeType.Manager)
        {
            Console.WriteLine("NonOpenClosedPrincibleEmployee:Info is pulling for Manager");
        }

        if (employeeType == EmployeeType.Developer)
        {
            Console.WriteLine("NonOpenClosedPrincibleEmployee:Info is pulling for Developer");
        }

        if (employeeType == EmployeeType.HumanResources)
        {
            Console.WriteLine("NonOpenClosedPrincibleEmployee:Info is pulling for Human Resources");
        }
    }
}

public interface IEmployee
{
    void GetEmployeeInfo();    
}

public class Manager : IEmployee
{
    public void GetEmployeeInfo()
    {
        Console.WriteLine("Info is pulling for Manager");

    }
}

public class Developer : IEmployee
{
    public void GetEmployeeInfo()
    {
        Console.WriteLine("Info is pulling for Developer");

    }
}

public class HumanResources : IEmployee
{
    public void GetEmployeeInfo()
    {
        Console.WriteLine("Info is pulling for Human Resources");

    }
}

public class Employee
{
    public void GetEmployeeInfo(IEmployee employee)
    {
        employee.GetEmployeeInfo();
    }
}
