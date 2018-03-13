using Web.Models;

namespace Web.Services
{
    public interface IConfigurationService
    {
        SiteConfiguration GetConfiguration();
        void SetConfiguration(SiteConfiguration configuration);
    }
}
