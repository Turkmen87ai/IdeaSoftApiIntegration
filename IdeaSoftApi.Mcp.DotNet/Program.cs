using IdeaSoftApi.Mcp.DotNet.Configuration;
using IdeaSoftApi.Mcp.DotNet.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.AddConsole(options =>
{
    // stdout MCP protokolüne ayrılmıştır; bütün loglar stderr'e gider.
    options.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services.AddSingleton(IdeaSoftMcpOptions.FromEnvironment());
builder.Services.AddSingleton<IdeaSoftMcpGateway>();
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly()
    .WithResourcesFromAssembly();

await builder.Build().RunAsync();
