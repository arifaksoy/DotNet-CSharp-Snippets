namespace DependencyInjection.Interface
{
    public interface ISingletonService
    {
        string GetGuid();
    }

    public interface IScopedService
    {
        string GetGuid();
    }

    public interface ITransientService
    {
        string GetGuid();
    }
}
