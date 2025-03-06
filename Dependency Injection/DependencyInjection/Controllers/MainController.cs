using DependencyInjection.Interface;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;

        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        public MainController(ISingletonService singletonService1, ISingletonService singletonService2, IScopedService scopedService1,IScopedService scopedService2, ITransientService transientService1, ITransientService transientService2)
        {
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
        }

        [HttpGet("singleton")]
        public IActionResult GetSingleton()
        {
            return Ok(new
            {
                Guid1 = _singletonService1.GetGuid(),
                Guid2 = _singletonService2.GetGuid(),
            });
        }

        [HttpGet("scoped")]
        public IActionResult GetScoped()
        {
            return Ok(new
            {
                Guid1 = _scopedService1.GetGuid(),
                Guid2 = _scopedService2.GetGuid(),
            });
        }
        [HttpGet("transient")]
        public IActionResult GetTransient()
        {
            return Ok(new
            {
                Guid1 = _transientService1.GetGuid(),
                Guid2 = _transientService2.GetGuid(),
            });
        }
    }
}
