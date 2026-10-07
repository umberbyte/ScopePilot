namespace ScopePilot.Services;

public static class BurpProxyLocation
{
    public const string EnvironmentVariable = "SCOPEPILOT_BURP_PROXY_JAR";
    public static string Resolve() => ResolvePath(Environment.GetEnvironmentVariable(EnvironmentVariable), ScopePilotDataPaths.RootDirectory);

    internal static string ResolvePath(string? configuredPath, string dataDirectory) =>
        string.IsNullOrWhiteSpace(configuredPath)
            ? Path.Combine(dataDirectory, "mcp", "mcp-proxy-all.jar")
            : Path.GetFullPath(configuredPath);
}
