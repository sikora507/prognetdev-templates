using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Prognetdev.Templates.Console.Setup;

public static class LoggingSetup
{
    public static HostApplicationBuilder SetupLogging(this HostApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();
        var loggerInit = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

        builder.Logging.AddSerilog(loggerInit);
        return builder;
    }
}