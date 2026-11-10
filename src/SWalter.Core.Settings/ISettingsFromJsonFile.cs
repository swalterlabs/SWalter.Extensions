using Microsoft.Extensions.Configuration;

namespace SWalter.Core.Settings;

/// <inheritdoc />
public interface ISettingsFromJsonFile : IValue<IConfiguration>
{
    /// <summary>
    /// </summary>
    public string SettingsFileName { get; }
}