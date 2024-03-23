using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Prognetdev.Templates.Console.Setup;

var builder = Host.CreateApplicationBuilder(args)
    .SetupConfiguration()
    .SetupLogging();

var host = builder.Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

logger.LogInformation("Hello from Prognetdev.Templates.Console!");

