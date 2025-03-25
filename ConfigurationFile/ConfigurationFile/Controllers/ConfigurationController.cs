using Microsoft.AspNetCore.Mvc;

namespace ConfigurationFile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
     private readonly ITestConfiguration _testConfiguration;
        public ConfigurationController(ITestConfiguration testConfiguration)
        {
            _testConfiguration = testConfiguration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var smtp = _testConfiguration.GetDirectConfiguration();
            var smtp2 = _testConfiguration.GetConfigurationWithIOption();
            return Ok(
                   new {with_IConfiguration = smtp , with_IOptions = smtp2}
                );
        }
    }
}
