using BepInEx;
using HarmonyLib;

namespace NoShardCap;

[BepInAutoPlugin(id: "io.github.danielstegink.noshardcap")]
public partial class NoShardCap : BaseUnityPlugin
{
    /// <summary>
    /// Static instance for ease of reference
    /// </summary>
    internal static NoShardCap instance;

    private void Awake()
    {
        // Put your initialization logic here
        instance = this;

        Harmony harmony = new Harmony(Id);
        harmony.PatchAll();

        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }

    /// <summary>
    /// Shared logger for external classes
    /// </summary>
    /// <param name="message"></param>
    internal void Log(string message)
    {
        Logger.LogInfo(message);
    }
}