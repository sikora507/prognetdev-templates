# pndconsole template
Template for console application with
* reading configuration from appsettings.json
* dependency injection
* serilog logging to file and console - taken from configuration in appsettings.json

# Install the template
`dotnet new -i Prognetdev.Templates.Console`

# Use the template
Generate the project in "TestConsole" directory by specifying the name just like you do with "console" template:

`dotnet new pndconsole -n TestConsole`

# Program.cs:
The Program.cs generated from this template will look like this:
```
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TestConsole.Setup;

var builder = Host.CreateApplicationBuilder(args)
    .SetupConfiguration()
    .SetupLogging();

var host = builder.Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

logger.LogInformation("Hello from TestConsole!");
```