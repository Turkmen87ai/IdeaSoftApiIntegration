using System.Text.Json;
using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

return await McpSample.RunAsync(args);

internal static class McpSample
{
    private static readonly string[] ExpectedTools =
    [
        "ideasoft_status",
        "ideasoft_authorization_url",
        "ideasoft_list",
        "ideasoft_get",
        "ideasoft_request",
        "ideasoft_webhook_list",
        "ideasoft_webhook_create",
        "ideasoft_webhook_update",
        "ideasoft_webhook_delete",
        "ideasoft_verify_webhook",
        "ideasoft_capabilities",
        "ideasoft_migration_checklist"
    ];

    private static readonly string[] ExpectedResources =
    [
        "ideasoft://guide/capabilities",
        "ideasoft://guide/security",
        "ideasoft://guide/migration"
    ];

    public static async Task<int> RunAsync(string[] args)
    {
        try
        {
            var server = ParseServer(args);
            var repositoryRoot = FindRepositoryRoot();
            var launch = CreateLaunch(server, repositoryRoot);
            using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(60));

            var options = new StdioClientTransportOptions
            {
                Name = $"IdeaSoftApi MCP {server} sunucusu",
                Command = launch.Command,
                Arguments = launch.Arguments,
                WorkingDirectory = repositoryRoot,
                InheritEnvironmentVariables = false,
                EnvironmentVariables = CreateSafeEnvironment()
            };

            await using var client = await McpClient.CreateAsync(
                new StdioClientTransport(options),
                cancellationToken: timeout.Token);

            var passed = 0;
            var tools = await client.ListToolsAsync(cancellationToken: timeout.Token);
            Check(
                ExpectedTools.Order().SequenceEqual(tools.Select(tool => tool.Name).Order()),
                $"12 araç bulundu ({server} sunucusu)");
            passed++;

            var resources = await client.ListResourcesAsync(cancellationToken: timeout.Token);
            Check(
                ExpectedResources.Order().SequenceEqual(resources.Select(resource => resource.Uri.ToString()).Order()),
                "3 rehber kaynağı bulundu");
            passed++;

            var capabilities = await client.CallToolAsync(
                "ideasoft_capabilities",
                cancellationToken: timeout.Token);
            var capabilitiesJson = GetStructuredJson(capabilities);
            Check(
                capabilities.IsError != true && capabilitiesJson.Contains("IdeaSoftApi MCP", StringComparison.Ordinal),
                "Yerel yetenek bilgisi okundu");
            passed++;

            var status = await client.CallToolAsync(
                "ideasoft_status",
                cancellationToken: timeout.Token);
            using (var statusDocument = JsonDocument.Parse(GetStructuredJson(status)))
            {
                var root = statusDocument.RootElement;
                Check(
                    status.IsError != true
                    && ReadBoolean(root, "writesEnabled") is false
                    && ReadBoolean(root, "secretsAreReturned") is false
                    && ReadBoolean(root, "accessTokenConfigured") is false,
                    "Secret aktarılmadan güvenli durum bilgisi alındı");
            }
            passed++;

            var migration = await client.CallToolAsync(
                "ideasoft_migration_checklist",
                cancellationToken: timeout.Token);
            var migrationJson = GetStructuredJson(migration);
            Check(
                migration.IsError != true
                && migrationJson.Contains("steps", StringComparison.OrdinalIgnoreCase)
                && migrationJson.Contains("safetyRules", StringComparison.OrdinalIgnoreCase),
                "Taşıma kontrol listesi okundu");
            passed++;

            var security = await client.ReadResourceAsync(
                "ideasoft://guide/security",
                cancellationToken: timeout.Token);
            var securityJson = JsonSerializer.Serialize(security);
            Check(
                securityJson.Contains("Secret", StringComparison.OrdinalIgnoreCase)
                && securityJson.Contains("yazma", StringComparison.OrdinalIgnoreCase),
                "Güvenlik kaynağı okundu");
            passed++;

            Console.WriteLine($"Sonuç: {passed}/6 test başarılı. İstemci=.NET 8, Sunucu={server}");
            return 0;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine($"[BAŞARISIZ] {exception.Message}");
            return 1;
        }
    }

    private static string ParseServer(string[] args)
    {
        if (args.Length == 0)
        {
            return "dotnet";
        }

        if (args.Length == 2 && args[0] == "--server" && args[1] is "dotnet" or "python")
        {
            return args[1];
        }

        throw new ArgumentException("Kullanım: --server dotnet|python");
    }

    private static (string Command, string[] Arguments) CreateLaunch(string server, string repositoryRoot) =>
        server switch
        {
            "dotnet" =>
            (
                "dotnet",
                ["run", "--project", Path.Combine(repositoryRoot, "IdeaSoftApi.Mcp.DotNet"), "-c", "Release", "--no-build"]
            ),
            "python" =>
            (
                "uv",
                ["run", "--offline", "--project", Path.Combine(repositoryRoot, "IdeaSoftApi.Mcp.Python"), "ideasoftapi-mcp"]
            ),
            _ => throw new ArgumentOutOfRangeException(nameof(server))
        };

    private static Dictionary<string, string?> CreateSafeEnvironment()
    {
        var environment = StdioClientTransportOptions.GetDefaultEnvironmentVariables();
        foreach (var name in environment.Keys.Where(name => name.StartsWith("IDEASOFT_", StringComparison.OrdinalIgnoreCase)).ToArray())
        {
            environment.Remove(name);
        }

        environment["DOTNET_NOLOGO"] = "1";
        environment["Logging__LogLevel__Default"] = "Warning";
        environment["NO_COLOR"] = "1";
        return environment;
    }

    private static string FindRepositoryRoot()
    {
        foreach (var start in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
        {
            var directory = new DirectoryInfo(start);
            while (directory is not null)
            {
                if (File.Exists(Path.Combine(directory.FullName, "IdeaSoftApiIntegration.sln")))
                {
                    return directory.FullName;
                }

                directory = directory.Parent;
            }
        }

        throw new DirectoryNotFoundException("IdeaSoftApiIntegration.sln bulunamadı.");
    }

    private static string GetStructuredJson(CallToolResult result)
    {
        if (result.StructuredContent is null)
        {
            throw new InvalidOperationException("Araç yapılandırılmış sonuç döndürmedi.");
        }

        return JsonSerializer.Serialize(result.StructuredContent);
    }

    private static bool? ReadBoolean(JsonElement element, string propertyName)
    {
        foreach (var property in element.EnumerateObject())
        {
            if (property.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase)
                && property.Value.ValueKind is JsonValueKind.True or JsonValueKind.False)
            {
                return property.Value.GetBoolean();
            }
        }

        return null;
    }

    private static void Check(bool condition, string description)
    {
        if (!condition)
        {
            throw new InvalidOperationException(description);
        }

        Console.WriteLine($"[BAŞARILI] {description}");
    }
}
