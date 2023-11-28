
public record struct PortConfig(
    string PortConfigFilePath,
    string PortConfigFileName = "ports.config.json",
    int ContainersRegistryPort = 19000,
    int ContainersUserInterfacePort = 19001,
    int PackagesUserInterfacePort = 19002
)
{
    public string GetPortConfigFullPath()
    {
        return Path.Combine(PortConfigFilePath, PortConfigFileName);
    }

    public string GetProjectNameFrommFolderName()
    {
        var projectName = new DirectoryInfo(PortConfigFilePath).Name;
        return string.IsNullOrWhiteSpace(projectName)
            ? Guid.NewGuid().ToString()
            : projectName.Replace(".", "-").ToLower();
    }
};
