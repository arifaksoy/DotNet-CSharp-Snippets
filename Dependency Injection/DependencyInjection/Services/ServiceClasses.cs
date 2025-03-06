using DependencyInjection.Interface;
namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly string _guid;
        public SingletonService() 
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
    public class ScopedService : IScopedService
    {
        private readonly string _guid;
        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
    public class TransientService : ITransientService
    {
        private readonly string _guid;
        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
