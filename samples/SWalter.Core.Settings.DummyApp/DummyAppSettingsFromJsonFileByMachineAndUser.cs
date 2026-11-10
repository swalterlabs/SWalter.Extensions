using SWalter.Core.Settings.ByMachineAndUser;
using SWalter.Core.Settings.Writable;

namespace SWalter.Core.Settings.DummyApp;

/// <inheritdoc cref="WritableSettingsFromJsonFile" />
public class DummyAppSettingsFromJsonFileByMachineAndUser : WritableSettingsFromJsonFile, IAppSettingsFromJsonFileByMachineAndUser
{
    /// <summary>
    ///     Constructor
    /// </summary>
    public DummyAppSettingsFromJsonFileByMachineAndUser()
        : base($"Settings/App.{Environment.MachineName}.{Environment.UserName}.Dummy.json", true)
    {
    }
}