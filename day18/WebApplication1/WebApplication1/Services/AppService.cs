using Microsoft.Extensions.Options;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class AppService : IAppService
{
    private AppSettings _settings;

    public AppService(IOptions<AppSettings> options) => _settings = options.Value;

    public string GetSiteInfo()
    {
        return $"Site: {_settings.SiteName} | Version: {_settings.Version}";
    }
}

