using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Prognetdev.Templates.Console.Setup;

public static class ConfigurationSetup
{
    public static HostApplicationBuilder SetupConfiguration(this HostApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("appsettings.json");
        return builder;
    }
}