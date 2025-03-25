using Microsoft.Extensions.Options;

namespace ConfigurationFile
{
    public class TestConfiguration : ITestConfiguration
    {
        private readonly IConfiguration _configuration;
        private readonly EmailSettings _settings;
        public TestConfiguration(IConfiguration configuration, IOptions<EmailSettings> options) 
        {
            _configuration = configuration;
            _settings = options.Value;
        }

        public string GetDirectConfiguration()
        {
            var smtp = _configuration["EmailSettings:SmtpServer"];
            return smtp;
        }

        public string GetConfigurationWithIOption()
        {
            return _settings.SmtpServer;
        }
    }
}
