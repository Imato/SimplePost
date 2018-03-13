using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Web.Models
{
    public class SiteConfiguration
    {
        public SiteConfiguration()
        {
            SiteYear = DateTime.UtcNow.Year;
            SiteVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        public string SiteName { get; set; }
        public int SiteYear { get; set; }
        public string SiteVersion { get; set; }
        public string LeteDbConnectionString { get; set; }
    }
}
