namespace ds.test.impl.Interfaces;

internal interface PluginFactory // Интерфейс, который должен быть реализован классом Plugins
{
    int PluginsCount { get; }
    string[] GetPluginNames { get; }
    IPlugin GetPlugin(string pluginName);
    void AddPlugin(IPlugin plugin);
}