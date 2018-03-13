using Web.Models;

namespace Web.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private SiteConfiguration _configuration;

        public SiteConfiguration GetConfiguration()
        {
            return _configuration;
        }

        public void SetConfiguration(SiteConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
